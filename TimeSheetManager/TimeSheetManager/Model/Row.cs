using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class Row
    {
        public Row(int rowNumber)
        {
            this.values = new Dictionary<Column, DataField>();
            this.rowNumber = rowNumber;
        }
        int rowNumber { get; set; }
        Dictionary<Column, DataField> values { get; set; }
    }
}
