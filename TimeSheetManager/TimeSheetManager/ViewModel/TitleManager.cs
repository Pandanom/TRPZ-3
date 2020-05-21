using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    public static class TitleManager
    {
        public static string GetStandartTitle(FieldType fieldType)
        {
            switch (fieldType)
            {
                case FieldType.date:
                    return "Date";
                case FieldType.mbtReq:
                    return "MBT Req. No.";               
                case FieldType.plan:
                    return "Plan";
                case FieldType.project:
                    return "Project";
                case FieldType.taskDesc:
                    return "Task Description";
                case FieldType.taskName:
                    return "Task Name";
                case FieldType.tfsReq:
                    return "TFS Req. No.";
                case FieldType.time:
                    return "Time";
            }
            return "";
        }
    }
}
