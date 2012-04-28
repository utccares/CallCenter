using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "CustomerListDto", Namespace = "")]
   public class CustomerListDto : List<CustomerDto>    { }

   [DataContract(Name = "CustomerDto", Namespace = "")]
   public class CustomerDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Name { get; set; }
   }
}
