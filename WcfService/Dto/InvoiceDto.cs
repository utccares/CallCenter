using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "InvoiceListDto", Namespace = "")]
   public class InvoiceListDto : List<InvoiceDto> { }

   [DataContract(Name = "InvoiceDto", Namespace = "")]
   public class InvoiceDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Reference { get; set; }
   }
}