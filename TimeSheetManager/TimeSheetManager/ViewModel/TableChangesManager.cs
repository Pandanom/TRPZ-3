using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    public class TableChangesManager
    {
        public List<TableMemento> TableVers { get; private set; }
        int maxVers;
        public TableChangesManager(int maxVers = 20)
        {
            this.maxVers = maxVers;
            TableVers = new List<TableMemento>();
        }

        public void addVersion(TableMemento newMem)
        {
            if (TableVers.Count >= maxVers)
                TableVers.RemoveAt(0);
            TableVers.Add(newMem);
        }

        public TableMemento GetVer(int num = 0)
        {
            if ((TableVers.Count - num) < TableVers.Count)
            {
                return TableVers[TableVers.Count - num - 1];
            }
            else
                return null;
        }
    }
}
