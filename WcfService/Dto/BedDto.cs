using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfService
{
   [DataContract(Name = "BedDto", Namespace = "")]
   public class BedDto
   {
      [DataMember(Order = 1)]
      public long Id { get; set; }

      [DataMember(Order = 2)]
      public string Poc { get; set; }  // Point of Care

      [DataMember(Order = 3)]
      public string Room { get; set; }

      [DataMember(Order = 4)]
      public string Bed { get; set; }

      [DataMember(Order = 5)]
      public string Extension { get; set; }
   }

   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "BedListDto", Namespace = "")]
   public class BedListDto : List<BedDto>
   {
   }
}
