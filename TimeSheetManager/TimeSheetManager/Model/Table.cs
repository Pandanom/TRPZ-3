using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class Table
    {
        public TableHeader header { get; set; }
        public TableData tableData { get; set; }

        public TableMemento SaveState()
        {
            return new TableMemento(this.tableData);
        }


        public void RestoreState(TableMemento memento)
        {
            this.tableData.rows = memento.rows;
        }


    }
}
