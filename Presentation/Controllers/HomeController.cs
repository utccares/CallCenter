using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WcfService;

namespace Presentation.Controllers
{
   [HandleError]
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewData["Message"] = "Welcome to ASP.NET MVC!";

         return View();
      }

      public ActionResult About()
      {
         return View();
      }

      public JsonResult ShowBedInfo()
      {
         BedDto retVal = null;
         long bedId = 44;

         string logMsg = String.Format("Home/ShowBedInfo for BedId: {0}", bedId);
         Logging.LogTrace(logMsg);
         
         try
         {
            UtcGetRequest getRequest = new UtcGetRequest();
            getRequest.Url = "http://localhost:1762";
            getRequest.Action = String.Format("/CallCenter/fred/bed/{0}.xml", bedId);

            UtcResponse response = WebCommon.GetUtcRequest(getRequest);
            if (response.Success == true)
            {
               if (!String.IsNullOrEmpty(response.Xml))
               {
                  retVal = XmlHelper.DeSerializeObj<BedDto>(response.Xml);
               }
               else
               {
                  logMsg += ", ERROR: The XML response is null or empty: " + getRequest.Url + getRequest.Action;
                  Logging.LogError(logMsg);
               }
            }
            else
            {
               logMsg += ", ERROR: " + getRequest.Url + getRequest.Action + " " + response.StatusCode + " " + response.ErrorMessage;
               Logging.LogError(logMsg);
            }

         }
         catch (Exception ex)
         {
            logMsg += ", EXCEPTION: " + ex.Message;
            Logging.LogError(logMsg, ex);
         }
         return Json(retVal, JsonRequestBehavior.AllowGet);
      }
   }
}
