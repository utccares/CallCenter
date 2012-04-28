using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "ServiceListDto", Namespace = "")]
   public class ServiceListDto : List<ServiceDto> { }

   [DataContract(Name = "ServiceDto", Namespace = "")]
   public class ServiceDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Text { get; set; }
      [DataMember]
      public decimal Rate { get; set; }
      [DataMember]
      public decimal Cap { get; set; }
      [DataMember]
      public decimal Fee { get; set; }
   }
}