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
      BedDto GetBed(string sessionKey, string bedId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/invoice/{invoiceId}.xml")]
      InvoiceDto GetInvoice(string sessionKey, string invoiceId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/customer/{customerId}.xml")]
      CustomerDto GetCustomer(string sessionKey, string customerId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/location/{locationId}.xml")]
      LocationDto GetLocation(string sessionKey, string locationId);

      [OperationContract]
      [WebGet(UriTemplate = "/{sessionKey}/notes/{noteId}.xml")]
      NoteDto GetNote(string sessionKey, string noteId);

      //[OperationContract]
      //[WebGet(UriTemplate = "/{sessionKey}/notes.xml")]
      //NoteListDto ListNote(string sesionKey, string invoiceId);

      //ServiceListDto ServiceList(long locationId);
      //PhoneListDto PhoneList(long invoiceId);
      //EmailListDto EmailList(long invoiceId);
      //AddressListDto AddressList(long invoiceId);
      //RentalListDto RentalList(long invoiceID);
  }
}
