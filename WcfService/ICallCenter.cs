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
      #region Get Methods

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/bed/{bedId}.xml")]
      BedDto GetBed(string sessionKey, string bedId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/customer/{customerId}.xml")]
      CustomerDto GetCustomer(string sessionKey, string customerId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/invoice/{invoiceId}.xml")]
      InvoiceDto GetInvoice(string sessionKey, string invoiceId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/location/{locationId}.xml")]
      LocationDto GetLocation(string sessionKey, string locationId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/note/{noteId}.xml")]
      NoteDto GetNote(string sessionKey, string noteId);

      #endregion

      #region List Methods

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/address/{invoiceId}.xml")]
      AddressListDto ListAddressForInvoice(string sessionKey, string invoiceId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/email/{invoiceId}.xml")]
      EmailListDto ListEmaiForInvoice(string sessionKey, string invoiceId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/note/invoice/{invoiceId}.xml")]
      NoteListDto ListNoteForInvoice(string sessionKey, string invoiceId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/phone/{invoiceId}.xml")]
      PhoneListDto ListPhoneForInvoice(string sessionKey, string invoiceId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/rental/{invoiceId}.xml")]
      RentalListDto ListRentalForInvoice(string sessionKey, string invoiceID);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/service/{locationId}.xml")]
      ServiceListDto ListServiceForLocation(string sessionKey, string locationId);

      #endregion
   }
}
