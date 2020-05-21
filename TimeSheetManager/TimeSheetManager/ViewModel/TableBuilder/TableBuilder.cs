using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    public abstract class TableBuilder
    {
        public Table table {get; private set;}
        protected TableHeader header;
        protected TableData data { get; set; }
        public string tableName { get; set; }
        public IEnumerable<Column> columns { get; set; }
        public void createTable()
        {
            table = new Table();
        }

        public abstract void CreateMandatoryColumns();
        public abstract void BuildHeader();
        public void BuildDataSet()
        {
            data = new TableData(header);
        }

        public void initTable()
        {
            table.header = header;
            table.tableData = data;
        }

        protected  IEnumerable<Column> GetNewColumsFromEnum(int[] enums)
        {
            int num = 0;
            List<Column> mandatoryCol = new List<Column>();
            foreach (var i in enums)
            {
                bool notExists = true;
                columns = columns ?? new List<Column>();
                foreach (var c in columns)
                {
                    if ((int)c.type == i)
                    {
                        notExists = false;
                        break;
                    }
                }
                if (notExists)
                {
                    mandatoryCol.Add(new Column(num, (FieldType)i, TitleManager.GetStandartTitle((FieldType)i)));
                    num++;
                }
            }
            foreach (var c in columns)
            {
                c.number = num;
                num++;
            }
           return mandatoryCol;

        }

    }
}
