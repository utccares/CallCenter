using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
   // Start the service and browse to http://<machine_name>:<port>/Service1/help to view the service's generated help page
   // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
   // a single instance of the service to process all calls.	
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
   public class CallCenter : ICallCenter
   {

      public BedDto GetBed_xml(string sessionKey, string bedId)
      { return GetBed("xml", sessionKey, bedId); }

      public BedDto GetBed_json(string sessionKey, string bedId)
      { return GetBed("json", sessionKey, bedId); }

      private BedDto GetBed(string callType, string sessionKey, string bedId)
      {
         BedDto retVal = new BedDto();

         retVal.Id = Convert.ToInt64(bedId);
         retVal.Poc = "Id-" + bedId;

         return retVal;
      }

      public LocationDto GetLocation(long locationId)
      {
         LocationDto retVal = new LocationDto();

         retVal.Id = locationId;

         return retVal;
      }

      public InvoiceDto GetInvoice(string sessionKey, string invoiceId)
      {
         InvoiceDto retVal = new InvoiceDto();

         retVal.Id = Convert.ToInt64(invoiceId);

         return retVal;
      }

      public CustomerDto GetCustomer(long customerId)
      {
         CustomerDto retVal = new CustomerDto();

         retVal.Id = customerId;
         retVal.Name = "Id-" + customerId;

         return retVal;
      }

      public NoteDto GetNote(long noteId)
      {
         NoteDto retVal = new NoteDto();

         retVal.Id = noteId;

         return retVal;
      }

   }
}
