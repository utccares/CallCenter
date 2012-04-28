using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfService
{
   [DataContract(Name = "NoteDto", Namespace = "")]
   public class NoteDto
   {
      [DataMember(Order = 1)]
      public long Id { get; set; }

      [DataMember(Order = 2)]
      public string Text { get; set; }
   }

   // http://msdn.microsoft.com/en-us/library/aa347850.aspx
   [CollectionDataContract(Name = "NoteListDto", Namespace = "")]
   public class NoteListDto : List<NoteDto>
   {
   }

}