<%@ Page Title="dis title" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SeniorDesign._Default" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
     <p>
          kekekekekekekekekek</p>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <ol class="round">
         <li class="three">
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="NumOfDays_TextChanged" Text="blah blah" />
              <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </li>
         <li class="three">
              <asp:TextBox ID="NumOfDays" runat="server" Columns="3" Height="25px" Width="111px">numofdays</asp:TextBox>
        </li>
         <li class="three">
              <asp:TextBox ID="shiftsPerDay" runat="server">shifts per day</asp:TextBox>
        </li>
    </ol>
     <p>
          <asp:Table ID="Table1" runat="server" Height="81px" Width="255px">
              <asp:TableRow runat="server">
              </asp:TableRow>
              <asp:TableRow runat="server">
              </asp:TableRow>
              <asp:TableRow runat="server">
              </asp:TableRow>
          </asp:Table>
    </p>
</asp:Content>
