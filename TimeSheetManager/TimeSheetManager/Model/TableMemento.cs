using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class TableMemento
    {
        public Dictionary<int, Row> rows { get; set; }
        public TableMemento(TableData data)
        {
            this.rows = data.rows;
        }
    }
}
