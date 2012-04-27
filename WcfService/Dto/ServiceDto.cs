using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   public class ServiceDto
   {
      public long Id { get; set; }
      public string Text { get; set; }
      public decimal Rate { get; set; }
      public decimal Cap { get; set; }
      public decimal Fee { get; set; }
   }
}