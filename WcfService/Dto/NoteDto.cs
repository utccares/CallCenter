using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "NoteListDto", Namespace = "")]
   public class NoteListDto : List<NoteDto> { }

   [DataContract(Name = "NoteDto", Namespace = "")]
   public class NoteDto
   {
      [DataMember]
      public long Id { get; set; }

      [DataMember]
      public string Text { get; set; }
   }
}