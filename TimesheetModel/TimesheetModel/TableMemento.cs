using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetModel
{
    public class TableMemento
    {
        public Dictionary<int, Row> rows { get; set; }
        public TableMemento(TableData data)
        {
            this.rows = data.rows;
        }

        public TableData CreateTableData(Column[] columns)
        {
            TableData ret = new TableData(columns);
            ret.rows = rows;
            return ret;
        }
    }
}
