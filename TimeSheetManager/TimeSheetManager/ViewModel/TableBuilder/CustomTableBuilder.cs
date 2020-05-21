using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;
namespace TimeSheetManager.ViewModel
{
    class CustomTableBuilder : TableBuilder
    {
        public override void BuildHeader()
        {
            header = new TableHeader(tableName, columns);
            header.tableType = TableType.custom;
        }

        public override void CreateMandatoryColumns()
        {
            
        }
    }
}
