using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "AddressListDto", Namespace = "")]
   public class AddressListDto : List<AddressDto> { }

   [DataContract(Name = "AddressDto", Namespace = "")]
   public class AddressDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Street { get; set; }
      [DataMember]
      public string City { get; set; }
      [DataMember]
      public string State { get; set; }
      [DataMember]
      public string Postal { get; set; }
      [DataMember]
      public int Priority { get; set; } // Used to determing the preferred address.  Higher value is more preferred.
   }
}