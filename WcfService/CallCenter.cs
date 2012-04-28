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
      #region Get Methods

      public BedDto GetBed(string sessionKey, string bedId)
      {
         BedDto retVal = new BedDto();

         long id = 0;
         long.TryParse(bedId, out id);
         retVal.Id = id;
         if (id == 1)
         {
            retVal.Poc = "12N";
            retVal.Room = "1001";
            retVal.Bed = "A";
            retVal.Extension = "1201";
         }
         else
         {
            retVal.Poc = "Poc-" + bedId;
         }

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
         if (id == 1)
         {
            retVal.Name = "Springfield General Hospital";
            retVal.InstructionsUrl = "www.google.com";
         }

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

      #endregion

      #region List Meethods

      public AddressListDto ListAddressForInvoice(string sessionKey, string invoiceId)
      {
         AddressListDto retVal = new AddressListDto();
         retVal.Add(new AddressDto { Id = 1, Street = "5160 Tortor Road, Apt. G", City = "Ontario", State = "MD", Postal = "97630" });
         return retVal;
      }

      public EmailListDto ListEmaiForInvoice(string sessionKey, string invoiceId)
      {
         EmailListDto retVal = new EmailListDto();
         retVal.Add(new EmailDto { Id = 1, Text = "x@ycom" });
         return retVal;
      }

      public NoteListDto ListNoteForInvoice(string sessionKey, string invoiceId)
      {
         NoteListDto retVal = new NoteListDto();
         retVal.Add(GetNote(sessionKey, "1"));
         retVal.Add(GetNote(sessionKey, "2"));
         return retVal;
      }

      public PhoneListDto ListPhoneForInvoice(string sessionKey, string invoiceId)
      {
         PhoneListDto retVal = new PhoneListDto();
         retVal.Add(new PhoneDto { Id = 1, Text = "713-578-4355", Status = 1, StatusDate = DateTime.Now });
         return retVal;
      }

      public RentalListDto ListRentalForInvoice(string sessionKey, string invoiceID)
      {
         RentalListDto retVal = new RentalListDto();
         ServiceDto serviceDto = new ServiceDto { Id = 1, Text = "Telephone", Rate = 5.50M, Cap = 97M, Fee = 7M };
         retVal.Add(new RentalDto { Id = 1, Service = serviceDto, RentDate = DateTime.Now });
         return retVal;
      }

      public ServiceListDto ListServiceForLocation(string sessionKey, string locationId)
      {
         ServiceListDto retVal = new ServiceListDto();

         retVal.Add(new ServiceDto { Id = 1, Text = "Telephone", Rate = 5.50M, Cap = 97M, Fee = 7M });
         retVal.Add(new ServiceDto { Id = 2, Text = "Television", Rate = 6.25M, Cap = 97M, Fee = 7M });
         retVal.Add(new ServiceDto { Id = 3, Text = "Combo - Telephone/Television", Rate = 11.75M, Cap = 97M, Fee = 7M });

         return retVal;
      }

      #endregion
   }
}
