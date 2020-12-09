<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Part2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <b>Username:</b><br>
    <asp:TextBox ID="UserTxt" runat="server"></asp:TextBox><br><br>
    <b>Password:</b><br>
    <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox><br>
    <asp:Button ID="LogonBtn" runat="server" Text="Log on" OnClick="LogonBtn_Click" /><br>
    <asp:Label ID="MessageLabel" runat="server"></asp:Label>
</asp:Content>
