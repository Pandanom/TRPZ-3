using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelsForWpf;
using DBLib;
using System.ServiceModel.Activation;

namespace TRPZWcfService
{
    public class UserRepository : ITableRepository
    {
       
          

        

        public async Task Create(User item)
        {
            using (var userRep = new UserRep())
                await userRep.Create(new DBLib.DBModel.User(item));
        }

        public async Task Delete(int id)
        {
            using (var userRep = new UserRep())
                await userRep.Delete(id);
        }


        public  List<User> GetItems()
        {
            using (var userRep = new UserRep())
            {
                var l = userRep.GetItems();
                List<User> ret = new List<User>();
                foreach (var u in l)
                    ret.Add(Converter.ToUser(u));
                return ret;
            }
        }


        public async Task Update(User item)
        {
            using (var userRep = new UserRep())
                await userRep.Update(new DBLib.DBModel.User(item));
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
