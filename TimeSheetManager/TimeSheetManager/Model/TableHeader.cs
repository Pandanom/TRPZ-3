using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    class TableHeader
    {

        public string tableName { get => tableName; set => tableName = value; }
        public long version { get; set; }
        public DateTime lastMod { get; set; }
        public IEnumerable<Column> columns { get; set; }

    }
}
