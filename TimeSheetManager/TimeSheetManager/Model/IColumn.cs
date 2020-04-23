using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public interface IColumn
    {
        Type Type { get; }
        int id { get; }
    }
}
