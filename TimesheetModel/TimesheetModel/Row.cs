using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetModel
{
    public class Row
    {
        public Row(int rowNumber)
        {
            this.values = new Dictionary<Column, DataField>();
            this.rowNumber = rowNumber;
        }
        public int rowNumber { get; set; }
        public Dictionary<Column, DataField> values { get; set; }
    }
}
