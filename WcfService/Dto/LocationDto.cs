using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "LocationListDto", Namespace = "")]
   public class LocationListDto : List<LocationDto> { }

   [DataContract(Name = "LocationDto", Namespace = "")]
   public class LocationDto
   {
      [DataMember]
      public long Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public DateTime Start { get; set; }
      [DataMember]
      public string Type { get; set; }
      [DataMember]
      public string Contract { get; set; }
      [DataMember]
      public bool CreditCardFlag { get; set; }
      [DataMember]
      public string InstructionsUrl { get; set; } //URL for iFrame href on the Instructions tab.
   }
}