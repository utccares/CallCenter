using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   public class AddressDto
   {
      public long Id { get; set; }
      public string Street { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string Postal { get; set; }
      public int Priority { get; set; } // Used to determing the preferred address.  Higher value is more preferred.
   }
}