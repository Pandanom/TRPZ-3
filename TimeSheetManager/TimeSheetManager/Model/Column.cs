using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class Column<T> : IColumn
    {
     

        Type IColumn.Type => typeof(T);

        int Id;

        int IColumn.id => Id;
    }
}
