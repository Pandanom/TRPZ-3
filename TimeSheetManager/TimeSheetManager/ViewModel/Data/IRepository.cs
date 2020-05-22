using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManager.ViewModel.Data
{
    public interface IRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> GetItems();
        Task<T> GetItemByID(int Id);
        Task Insert(T item);
        Task Delete(int id);
        Task Update(T item);
        Task Save();


    }
}
