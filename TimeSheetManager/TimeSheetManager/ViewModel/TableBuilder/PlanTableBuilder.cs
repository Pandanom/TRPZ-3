using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    class PlanTableBuilder : TableBuilder
    {

        public override void BuildHeader()
        {
            header = new TableHeader(tableName, columns);
            header.tableType = TableType.plan;
        }

        public override void CreateMandatoryColumns()
        {

            int[] enums = new int[] { 1, 2, 3, 4, 5, 7 };
            columns = columns.Concat(GetNewColumsFromEnum(enums));
        }
    }
}
