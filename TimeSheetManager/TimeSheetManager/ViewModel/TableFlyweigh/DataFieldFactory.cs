using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel.TableFlyweigh
{
    public class DataFieldFactory
    {
        Hashtable flyweights = new Hashtable();
        public DataFieldFactory()
        {
        }
        public DataField GetFlyweight(int key)
        {
            if (!flyweights.ContainsKey(key))
                return null;
            return flyweights[key] as DataField;
        }

        public int GetKey(DataField dataField)
        {
            var key = dataField.GetHashCode();
            if (flyweights.ContainsKey(key))
                return key;
            else
            {
                flyweights.Add(key, dataField);
                return key;
            }
        }
    }
}
