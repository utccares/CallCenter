using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "RentalListDto", Namespace = "")]
   public class RentalListDto : List<RentalDto> { }

   [DataContract(Name = "RentalDto", Namespace = "")]
   public class RentalDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public ServiceDto Service { get; set; }
      [DataMember]
      public DateTime RentDate { get; set; }
   }
}