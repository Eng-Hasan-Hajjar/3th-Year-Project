<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        username</p>
<p>
    <asp:TextBox ID="txtlogname" runat="server" CssClass="inputs" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="usernamerequired" runat="server" ControlToValidate="txtlogname" ErrorMessage="please enter a username" ForeColor="#FF3300"></asp:RequiredFieldValidator>
</p>
    <p>
        user firstname</p>
    <p>
        <asp:TextBox ID="txtfname" runat="server" CssClass="inputs"></asp:TextBox>
</p>
    <p>
        user surname</p>
    <p>
        <asp:TextBox ID="txtlname" runat="server" CssClass="inputs"></asp:TextBox>
</p>
<p>
    password</p>
<p>
    <asp:TextBox ID="txtpassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
</p>
<p>
    confirm password</p>
<p>
    <asp:TextBox ID="txtconfirmpassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtconfirmpassword" ControlToValidate="txtpassword" ErrorMessage="the password is not matched " ForeColor="#FF3300"></asp:CompareValidator>
</p>
    <p>
        user email</p>
    <p>
        <asp:TextBox ID="txtemail" runat="server" CssClass="inputs"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="please type your email correctly" ForeColor="#FF0033" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
</p>
<p>
    <asp:Button ID="btnregister" runat="server" CssClass="button" OnClick="btnregister_Click" Text="Register" />
</p>
    <p>
        <asp:Label ID="lblregstatus" runat="server" ForeColor="#FF3300"></asp:Label>
</p>
</asp:Content>

