using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel.Data
{
    class TableServerRep : IRepository<Table>
    {
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Table> GetItemByID(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Table>> GetItems()
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Table item)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Table item)
        {
            throw new NotImplementedException();
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
        // ~TableServerRep() {
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
