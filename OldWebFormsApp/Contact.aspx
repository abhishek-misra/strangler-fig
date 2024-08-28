<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="OldWebFormsApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your contact page.</h3>
        <address>
            <%= AddressLine1 %><br />
            <%= AddressLine2 %><br />
            <abbr title="Phone">P:</abbr>
            <%= Phone %>
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:<%= SupportEmail %>"><%= SupportEmail %></a><br />
            <strong>Marketing:</strong> <a href="mailto:<%= MarketingEmail %>"><%= MarketingEmail %></a>
        </address>
    </main>
</asp:Content>
