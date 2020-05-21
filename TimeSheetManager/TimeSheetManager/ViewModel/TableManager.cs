using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    public static class TableManager
    {
        public static Table createTable(string tableName, IEnumerable<Column> columns, TableType type = TableType.custom)
        {
            TableBuilder builder;
            switch (type)
            {
                case TableType.timesheet:
                    builder = new TimesheetTableBuilder();
                    break;
                case TableType.plan:
                    builder = new PlanTableBuilder();
                    break;
                default:
                    builder = new CustomTableBuilder();
                    break;
            }
            builder.createTable();
            builder.columns = columns;
            builder.tableName = tableName;
            builder.CreateMandatoryColumns();
            builder.BuildHeader();
            builder.BuildDataSet();
            builder.initTable();
            return builder.table;
        }
        public static Table createTable (TableBuilder builder)
        {   
            builder.createTable();
            builder.CreateMandatoryColumns();
            builder.BuildHeader();
            builder.BuildDataSet();
            builder.initTable();
            return builder.table;
        }
    }
}
