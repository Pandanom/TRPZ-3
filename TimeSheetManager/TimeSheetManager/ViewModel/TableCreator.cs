using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TimeSheetManager.Model;
using TimeSheetManager.ViewModel.Data;

namespace TimeSheetManager.ViewModel
{
    class TableCreator
    {
        public TableCreator(TableBuilder tableBuilder, TableChangesManager tableChanges, IRepository<Table> repository)
        {
            this.tableBuilder = tableBuilder;
            this.tableChanges = tableChanges;
            this.repository = repository;
        }

        public IRepository<Table> repository { get; set; }
        public TableBuilder tableBuilder { get; set; }
        public TableChangesManager tableChanges { get; set; }
        public Table table { get; set; }
        public DataGridBuilder gridBuilder { get; set; }
        public async Task initTable()
        {
            table = TableManager.createTable(tableBuilder);
            await tableChanges.addVersion(table.SaveState()).ConfigureAwait(false);
            await repository.Insert(table).ConfigureAwait(false);

        }
        public DataGrid Createinterface()
        {
            gridBuilder = new DataGridBuilder(table); 
            DataGrid dataGrid = new DataGrid();
            dataGrid.Margin = new System.Windows.Thickness( 200,50,100,50);
            gridBuilder.CreateColumns(ref dataGrid);
            dataGrid.SelectedCellsChanged += DataGrid_SelectedCellsChanged;
            return dataGrid;
        }

        private async void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var dg = sender as DataGrid;
            IList<DataGridCellInfo> selectedcells = e.AddedCells;
            table = await TableManager.DataChanged(table, selectedcells);
        
        }

        public async Task LoadTable()
        {
            table = await repository.GetItemByID(UserInfo.getInstance().Id).ConfigureAwait(false);
        }

    }
}
