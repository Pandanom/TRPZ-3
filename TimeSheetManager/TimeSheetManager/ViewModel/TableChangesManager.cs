using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;
using TimeSheetManager.ViewModel.TableFlyweigh;

namespace TimeSheetManager.ViewModel
{
    public class TableChangesManager
    {
        public List<CompressedTableData> TableVers { get; private set; }
        int maxVers;
        DataFieldFactory fieldFactory = new DataFieldFactory();
        Column[] columns;
        public TableChangesManager(Column[] columns, int maxVers = 20)
        {
            this.columns = columns;
            this.maxVers = maxVers;
            TableVers = new List<CompressedTableData>();
        }

        public async Task addVersion(TableMemento newMem)
        {
            if (TableVers.Count >= maxVers)
                TableVers.RemoveAt(0);
            CompressedTableData tableData = new CompressedTableData();
            var t = tableData.Init(newMem.CreateTableData(columns), fieldFactory).ConfigureAwait(false);
            TableVers.Add(tableData);
        }

        public async Task<TableMemento> GetVer(int ver = 0)
        {
            if ((TableVers.Count - ver) < TableVers.Count)
            {
               return (await TableVers[TableVers.Count - ver - 1].RestoreTable(fieldFactory).ConfigureAwait(false)).State();
            }
            else
                return null;
        }
    }
}
