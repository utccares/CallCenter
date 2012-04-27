using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfService
{
   public class LocationDto
   {
      public long Id { get; set; }
      public string Name { get; set; }
      public DateTime Start { get; set; }
      public string Type { get; set; }
      public string Contract { get; set; }
      public bool CreditCardFlag { get; set; }
      public string Instructions { get; set; } //URL for iFrame href on the Instructions tab.
   }
}