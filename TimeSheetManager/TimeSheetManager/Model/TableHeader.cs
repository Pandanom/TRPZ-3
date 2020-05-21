using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class TableHeader
    {
        public TableHeader(string tableName, IEnumerable<Column> columns)
        {
            this.tableName = tableName;
            this.columns = columns;
            this.version = 0;
            this.lastMod = DateTime.Now;
            tableType = TableType.custom;
        }

        public string tableName { get; set; }
        public long version { get; set; }
        public DateTime lastMod { get; set; }
        public IEnumerable<Column> columns { get; set; }
        public TableType tableType { get; set; }


    }
}
