using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public abstract class DataField
    {
        FieldType type { get; set; }
        object data { get; set; }

    }
}
