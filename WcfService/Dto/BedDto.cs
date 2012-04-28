using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "BedListDto", Namespace = "")]
   public class BedListDto : List<BedDto> { }

   [DataContract(Name = "BedDto", Namespace = "")]
   public class BedDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Poc { get; set; }  // Point of Care
      [DataMember]
      public string Room { get; set; }
      [DataMember]
      public string Bed { get; set; }
      [DataMember]
      public string Extension { get; set; }
   }
}
