using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
   // Start the service and browse to http://<machine_name>:<port>/CallCenter/help to view the service's generated help page
   // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
   // a single instance of the service to process all calls.	
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
   public class CallCenter : ICallCenter
   {
      public BedDto GetBed(string sessionKey, string bedId)
      {
         BedDto retVal = new BedDto();

         long id = 0;
         long.TryParse(bedId, out id);
         retVal.Id = id;
         retVal.Poc = "Poc-" + bedId;

         return retVal;
      }

      public InvoiceDto GetInvoice(string sessionKey, string invoiceId)
      {
         InvoiceDto retVal = new InvoiceDto();

         long id = 0;
         long.TryParse(invoiceId, out id);
         retVal.Id = id;

         return retVal;
      }

      public LocationDto GetLocation(string sessionKey, string locationId)
      {
         LocationDto retVal = new LocationDto();

         long id = 0;
         long.TryParse(locationId, out id);
         retVal.Id = id;

         return retVal;
      }

      public CustomerDto GetCustomer(string sessionKey, string customerId)
      {
         CustomerDto retVal = new CustomerDto();

         long id = 0;
         long.TryParse(customerId, out id);
         retVal.Id = id;
         retVal.Name = "Rush Inuit";

         return retVal;
      }

      public NoteDto GetNote(string sessionKey, string noteId)
      {
         NoteDto retVal = new NoteDto();

         long id = 0;
         long.TryParse(noteId, out id);
         retVal.Id = id;
         retVal.Text = "Note: " + DateTime.Now.ToString();

         return retVal;
      }


      public NoteListDto ListNote(string sessionKey, string invoiceId)
      {
         NoteListDto retVal = new NoteListDto();
         retVal.Add(GetNote(sessionKey, "1"));
         retVal.Add(GetNote(sessionKey, "2"));
         return retVal;
      }
   }
}
