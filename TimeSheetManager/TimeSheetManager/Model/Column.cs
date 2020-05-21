using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class Column
    {
        public Column()
        {
        }

        public Column(int number, FieldType type, string title)
        {
            this.number = number;
            this.type = type;
            this.title = title;
        }

        public int number { get; set; }
        public FieldType type { get; set; }
        public string title { get; set; }
      
    }
}
