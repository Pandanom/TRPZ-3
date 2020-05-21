using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public enum FieldType : int
    {
        date = 1,
        project = 2,
        mbtReq = 3,
        tfsReq = 4,
        taskName = 5,
        taskDesc = 6,
        plan = 7,
        time = 10,
        other = 0

    }
}
