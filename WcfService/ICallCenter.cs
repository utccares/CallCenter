using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{

   [ServiceContract]
   public interface ICallCenter
   {
      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/bed/{bedId}.xml")]
      BedDto GetBed_xml(string sessionKey, string bedId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/bed/{bedId}.json",
         ResponseFormat = WebMessageFormat.Json)]
      BedDto GetBed_json(string sessionKey, string bedId);

   }
}
