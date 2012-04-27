using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;

public class XmlHelper
{

   #region UTF8ByteArray Functions from : http://geekswithblogs.net/paulwhitblog/archive/2007/07/20/114076.aspx

   public static Byte[] StringToUTF8ByteArray(string pXmlString)
   {
      //UTF8Encoding encoding = new UTF8Encoding();
      UTF32Encoding encoding = new UTF32Encoding();
      byte[] byteArray = encoding.GetBytes(pXmlString);
      return byteArray;
   }

   public static string UTF8ByteArrayToString(byte[] characters)
   {
      UTF8Encoding encoding = new UTF8Encoding();
      string constructedString = encoding.GetString(characters);
      return (constructedString);
   }

   #endregion

   //        public static string GetXMLParam<t>(t searchCriteria)

   public static T DeSerializeObj<T>(string xmlString)
   {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
      MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(xmlString));
      XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

      return (T)xmlSerializer.Deserialize(memoryStream);
   }

   public static T DeSerializeObjList<T>(string xmlString)
   {
      // http://www.calvinirwin.net/2011/02/10/xmlserialization-deserialize-causes-xmlns-was-not-expected/
      XmlRootAttribute xRoot = new XmlRootAttribute();
      xRoot.ElementName = typeof(T).Name;
      xRoot.IsNullable = true;

      XmlSerializer ser = new XmlSerializer(typeof(T), xRoot);
      XmlReader xRdr = XmlReader.Create(new StringReader(xmlString));

      return (T)ser.Deserialize(xRdr);
   }

   public static string GetXMLParam<t>(t objInstance)
   {
      string retVal = "";

      XmlSerializer Serializer = new XmlSerializer(typeof(t));

      XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
      ns.Add("", "");

      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Indent = false;
      settings.OmitXmlDeclaration = true;
      settings.Encoding = Encoding.ASCII;


      MemoryStream ms = new MemoryStream();
      XmlWriter writer = XmlWriter.Create(ms, settings);

      Serializer.Serialize(writer, objInstance, ns);

      ms.Position = 0;
      using (StreamReader smr = new StreamReader(ms))
      {
         ms.Flush();
         retVal = smr.ReadToEnd();
      }
      return retVal;
   }

   public static string GetXML<t>(t objInstance)
   {
      string retVal = "";

      XmlSerializer Serializer = new XmlSerializer(typeof(t));

      MemoryStream ms = new MemoryStream();
      XmlWriter writer = XmlWriter.Create(ms);

      Serializer.Serialize(writer, objInstance);

      ms.Position = 0;
      using (StreamReader smr = new StreamReader(ms))
      {
         ms.Flush();
         retVal = smr.ReadToEnd();
      }
      return retVal;
   }

   public static string GetXMLForList<t>(List<t> objList)
   {
      string retVal = "";

      XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<t>));

      XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
      ns.Add("", "");

      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Indent = false;
      settings.OmitXmlDeclaration = true;
      settings.Encoding = Encoding.ASCII;

      MemoryStream ms = new MemoryStream();
      XmlWriter writer = XmlWriter.Create(ms, settings);

      try
      {
         xmlSerializer.Serialize(writer, objList, ns);
      }
      catch (Exception ex)
      {
         Console.WriteLine("ERROR: " + ex.Message);
      }

      ms.Position = 0;
      using (StreamReader smr = new StreamReader(ms))
      {
         ms.Flush();
         retVal = smr.ReadToEnd();
      }
      return retVal;
   }

}
