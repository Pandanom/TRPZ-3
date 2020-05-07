﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.Model
{
    public class Column<T>
    {
        public int number { get; set; }
        public FieldType type { get; set; }
        public string title { get; set; }

    }
}
