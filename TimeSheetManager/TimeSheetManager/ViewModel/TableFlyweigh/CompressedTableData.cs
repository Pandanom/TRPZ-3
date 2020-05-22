using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel.TableFlyweigh
{
    public class CompressedTableData
    {
        int[,] DataFieldHash;
        int rows, columns;
        Column[] columnHeaders;
        public CompressedTableData()
        {

        }

        public async Task Init(TableData tableData, DataFieldFactory factory)
        {
            await Task.Run(() => 
            { 
                rows = tableData.rows.Count;
                columns = tableData.columns.Count();
                columnHeaders = tableData.columns;
                DataFieldHash = new int[rows, columns];
                int i = 0;
                int j = 0;
                foreach(var row in tableData.rows)
                {
                    foreach (var field in row.Value.values)
                    {
                        DataFieldHash[i, j] = factory.GetKey(field.Value);
                        j++;
                    }
                    j = 0;
                    i++;
                }
            });
        }

        public async Task<TableData> RestoreTable(DataFieldFactory factory)
        {
            TableData ret = new TableData(columnHeaders);
            await Task.Run(() =>
            {
                for (int i = 0; i < rows; i++)
                {
                    Row row = new Row(i);
                    for (int j = 0; j < columns; j++)
                    {
                        var hash = DataFieldHash[i, j];
                        row.values.Add(columnHeaders[j], factory.GetFlyweight(hash));
                    }
                    ret.rows.Add(i, row);
                }
            });
            return ret;
        }

    }
}
