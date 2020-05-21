using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class TableData
    {
        public TableData(TableHeader header)
        {
            this.columns = header.columns.ToArray();
            rows = new Dictionary<int, Row>();
        }

        public Dictionary<int, Row> rows { get; set; }
        public Column[] columns { get; set; }

        void AddRow() { }
        void SetValue() { }
        void DelRow() { }
    }
}
