using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfService
{
   public class CallCenter : ICallCenter
   {
      public BedDto GetBed(long bedId)
      {
         BedDto retVal = new BedDto();

         retVal.Id = bedId;
         retVal.Poc = "Id-" + bedId;

         return retVal;
      }
   }
}
