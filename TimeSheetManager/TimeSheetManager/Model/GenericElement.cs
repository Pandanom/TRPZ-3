using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class GenericElement<T> : IElement
    {
        public Type Type => typeof(T);
        T value;
        public object GetValue()
        {
            return value as object;
        }
    }
}
