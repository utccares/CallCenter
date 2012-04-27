<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Home Page
</asp:Content>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
   <script type="text/javascript">

      $(function () {

         $.ajax({
            type: 'GET',
            url: '/Home/ShowBed',
            success: ShowBedInfo(data)
         });
      });


      function ShowBedInfo(data) {
         alert("we got here");
      }


   </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <h2>
      <%= Html.Encode(ViewData["Message"]) %></h2>
   <p>
      To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">
         http://asp.net/mvc</a>.
   </p>
</asp:Content>
