using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "EmailListDto", Namespace = "")]
   public class EmailListDto : List<EmailDto> { }

   [DataContract(Name = "EmailDto", Namespace = "")]
   public class EmailDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Text { get; set; }
   }
}
