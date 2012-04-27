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
   }
}
      