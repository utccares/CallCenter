using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   public class InvoiceDto
   {
      public long Id { get; set; }
      public string Reference { get; set; }
   }
}