using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfService
{
   public interface ICallCenter
   {

      BedDto GetBed(long bedId);
   }
}
