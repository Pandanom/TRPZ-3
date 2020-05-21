using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    class TableFacade
    {
        public TableFacade(TableBuilder tableBuilder, TableChangesManager tableChanges)
        {
            this.tableBuilder = tableBuilder;
            this.tableChanges = tableChanges;
        }

        public TableBuilder tableBuilder { get; set; }
        public TableChangesManager tableChanges { get; set; }
        public Table table { get; set; }
        public DataGridBuilder gridBuilder { get; set; }
        public void initTable()
        {
            table = TableManager.createTable(tableBuilder);
            tableChanges.addVersion(table.SaveState());

        }
        public DataGrid Createinterface()
        {
            gridBuilder = new DataGridBuilder(table); 
            DataGrid dataGrid = new DataGrid();
            dataGrid.Margin = new System.Windows.Thickness( 200,50,100,50);
            gridBuilder.CreateColumns(ref dataGrid);
            return dataGrid;
        }

    }
}
