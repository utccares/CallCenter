using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   public class PhoneDto
   {
      public long Id { get; set; }
      public string Text { get; set; }
      public int Status { get; set; }
      public DateTime StatusDate { get; set; }
   }
}