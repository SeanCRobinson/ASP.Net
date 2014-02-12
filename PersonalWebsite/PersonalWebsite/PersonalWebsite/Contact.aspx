<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PersonalWebsite.Three" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="height: 245px; width: 557px">Email: <a href="mailto:SeanCR93@gmail.com">SeanCR93@gmail.com</a><br />
        <br />
        <asp:Label ID="lblLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TxtCustomer" runat="server" Width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGetCustomer" runat="server" OnClick="btnGetCustomer_Click" style="margin-left: 0px" Text="Get Customer" />
    </h1>
</asp:Content>
