using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using PropertyLayer;

namespace FoxService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInterviewSection" in both code and config file together.
    [ServiceContract]
    public interface IInterviewSection
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DashbaordData")]
        List<Category> DashbaordData();
    }
}
