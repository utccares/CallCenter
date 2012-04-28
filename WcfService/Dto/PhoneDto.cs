using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "PhoneListDto", Namespace = "")]
   public class PhoneListDto : List<PhoneDto> { }

   [DataContract(Name = "PhoneDto", Namespace = "")]
   public class PhoneDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Text { get; set; }
      [DataMember]
      public int Status { get; set; }
      [DataMember]
      public DateTime StatusDate { get; set; }
   }
}