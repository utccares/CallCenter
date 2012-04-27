using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;


namespace Presentation
{
   public class WebCommon
   {
      //      internal const string SubDomain = "utc";
      //      internal const string ApiToken = "palm428naval";

      public static UtcResponse GetUtcRequest(UtcGetRequest getRequest)
      {
         UtcResponse retVal = new UtcResponse();

         string url = getRequest.Url + getRequest.Action;

         HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(url);
         //CredentialCache myCache = new CredentialCache();
         //myCache.Add(new Uri(url), "Basic", new NetworkCredential(ApiToken, ""));
         //myReq.Credentials = myCache;

         myReq.ContentType = "application/xml";
         myReq.ContentLength = 0;
         myReq.Method = "GET";

         try
         {
            HttpWebResponse wr = (HttpWebResponse)myReq.GetResponse();
            retVal.StatusCode = (int)wr.StatusCode;

            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            retVal.Xml = reader.ReadToEnd();
            retVal.Success = true;
         }
         catch (WebException ex)
         {
            HttpWebResponse exResponse = (HttpWebResponse)ex.Response;
            retVal.StatusCode = (int)exResponse.StatusCode;
            retVal.ErrorMessage = ex.Message;
         }
         return retVal;
      }

      public static UtcResponse PutUtcRequest(UtcPutRequest putRequest)
      {
         UtcResponse retVal = new UtcResponse();

         string url = putRequest.Url + putRequest.Action;

         HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(url);
         //CredentialCache myCache = new CredentialCache();
         //myCache.Add(new Uri(url), "Basic", new NetworkCredential(ApiToken, ""));
         //myReq.Credentials = myCache;

         // byte[] byteArray = Encoding.UTF8.GetBytes(putRequest.XmlDoc.InnerXml);
         byte[] byteArray = Encoding.UTF8.GetBytes(putRequest.XmlDoc);

         myReq.ContentType = "application/xml";
         myReq.ContentLength = byteArray.Length;
         myReq.Method = "POST";

         Stream dataStream = myReq.GetRequestStream();
         dataStream.Write(byteArray, 0, byteArray.Length);
         dataStream.Close();

         try
         {
            HttpWebResponse wr = (HttpWebResponse)myReq.GetResponse();
            retVal.StatusCode = (int)wr.StatusCode;

            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            retVal.Xml = reader.ReadToEnd();
            retVal.Success = true;
         }
         catch (WebException ex)
         {
            HttpWebResponse exResponse = (HttpWebResponse)ex.Response;
            retVal.StatusCode = (int)exResponse.StatusCode;
            retVal.ErrorMessage = ex.Message;
         }
         return retVal;
      }

      public static UtcResponse PostUtcRequest(UtcPostRequest postRequest)
      {
         UtcResponse retVal = new UtcResponse();

         string url = postRequest.Url + postRequest.Action;

         HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(url);
         //CredentialCache myCache = new CredentialCache();
         //myCache.Add(new Uri(url), "Basic", new NetworkCredential(ApiToken, ""));
         //myReq.Credentials = myCache;

         // byte[] byteArray = Encoding.UTF8.GetBytes(putRequest.XmlDoc.InnerXml);
         byte[] byteArray = Encoding.UTF8.GetBytes(postRequest.XmlDoc);

         myReq.ContentType = "application/xml";
         myReq.ContentLength = byteArray.Length;
         myReq.Method = "POST";

         Stream dataStream = myReq.GetRequestStream();
         dataStream.Write(byteArray, 0, byteArray.Length);
         dataStream.Close();

         try
         {
            HttpWebResponse wr = (HttpWebResponse)myReq.GetResponse();
            retVal.StatusCode = (int)wr.StatusCode;

            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            retVal.Xml = reader.ReadToEnd();
            retVal.Success = true;
         }
         catch (WebException ex)
         {
            HttpWebResponse exResponse = (HttpWebResponse)ex.Response;
            retVal.StatusCode = (int)exResponse.StatusCode;
            retVal.ErrorMessage = ex.Message;
         }
         return retVal;
      }

   }

   public class UtcPutRequest
   {
      public string Url { get; set; }
      public string Action { get; set; }
      public string XmlDoc { get; set; }

      public UtcPutRequest()
      {
         Url = "http://msg.utccares.net:8300";
      }

      public UtcPutRequest(string action, string xmlDocument)
         : this()
      {
         Action = action;
         XmlDoc = xmlDocument;
      }
   }

   public class UtcPostRequest
   {
      public string Url { get; set; }
      public string Action { get; set; }
      public string XmlDoc { get; set; }

      public UtcPostRequest()
      {
         Url = "http://msg.utccares.net:8300";
      }

      public UtcPostRequest(string action, string xmlDocument)
         : this()
      {
         Action = action;
         XmlDoc = xmlDocument;
      }
   }


   public class UtcGetRequest
   {
      public string Url { get; set; }
      public string Action { get; set; }

      public UtcGetRequest()
      {
         Url = "http://msg.utccares.net:8300";
      }

      public UtcGetRequest(string action)
         : this()
      {
         Action = action;
      }
   }

   public class UtcResponse
   {
      public string Xml { get; set; }
      public int NewId { get; set; }
      public bool Success { get; set; }
      public int StatusCode { get; set; }
      public string ErrorMessage { get; set; }
   }

}
