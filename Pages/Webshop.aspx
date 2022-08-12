<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Webshop.aspx.cs" Inherits="Pages_Webshop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddlcategory" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="catName" DataValueField="catID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StoreDBConnectionString %>" SelectCommand="SELECT [catName], [catID] FROM [tblCategory]"></asp:SqlDataSource>
    <br />
    <asp:Panel ID="productpnl" runat="server">
    </asp:Panel>
    <div style="clear:both"></div>
</asp:Content>

