
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   [DataContract(Name = "CustomerDto", Namespace = "")]
   public class CustomerDto
   {
      [DataMember(Order = 1)]
      public long Id { get; set; }
      [DataMember(Order = 2)]
      public string Name { get; set; }
   }

   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "CustomerListDto", Namespace = "")]
   public class CustomerListDto : List<CustomerDto>
   {
   }

}
