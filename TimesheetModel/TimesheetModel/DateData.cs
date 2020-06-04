using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetModel
{
    public class DateData : DataField
    {
        DateTime data { get; set; }
        public override int GetHashCode()
        {
            return data.GetHashCode();
        }
    }
}
