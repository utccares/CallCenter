using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   public class RentalDto
   {
      public long Id { get; set; }
      public ServiceDto Service { get; set; }
      public DateTime RentDate { get; set; }
   }
}