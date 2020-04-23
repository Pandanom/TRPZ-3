using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.ViewModel
{
    class UserInfo
    {
        private static UserInfo instance;
        public string Name { get; private set; }
        public int Id { get; private set; }
        protected UserInfo(string name, int id)
        {
            this.Name = name;
            this.Id = Id;
        }

        public static UserInfo getInstance(string name = "", int id = 0)
        {
            if (instance == null)
                instance = new UserInfo(name, id);
            return instance;
        }
        
    }
}
