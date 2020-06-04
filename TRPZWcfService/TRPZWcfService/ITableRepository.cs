using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using ModelsForWpf;

namespace TRPZWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserRepository" in both code and config file together.
    [ServiceContract]
    public interface ITableRepository:IDisposable
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetItems")]
        List<User> GetItems();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Task Create(User item);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Update", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Task Update(User item);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Task Delete(int id);
      
    }
}
