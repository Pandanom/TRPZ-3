using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
    class UserSettings
    {
        private static UserSettings instance;
        public TableTemplate Template { get; private set; }
        public int Id { get; private set; }
        protected UserSettings(TableTemplate template, int id)
        {
            this.Template = template;
            this.Id = Id;
        }

        public static UserSettings getInstance(TableTemplate template = null, int id = 0)
        {
            if (instance == null)
                instance = new UserSettings(template, id);
            return instance;
        }
    }
}
