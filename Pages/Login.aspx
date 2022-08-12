<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="lblregistersuccess" runat="server" ForeColor="#FF0033"></asp:Label>
</p>
    <p>
    username&nbsp;
    <asp:TextBox ID="txtuserlogin" runat="server" CssClass="inputs"></asp:TextBox>
</p>
<p>
    password&nbsp;
    <asp:TextBox ID="txtpasslogin" runat="server" CssClass="inputs"></asp:TextBox>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnlogin" runat="server" CssClass="button" Text="Login" OnClick="btnlogin_Click" />
&nbsp;&nbsp;&nbsp;
</p>
</asp:Content>

