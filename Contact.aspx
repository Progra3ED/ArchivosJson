<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ArchivosXML.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Leer datos del Json</h2>    
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="ButtonCargar" runat="server" CssClass="btn btn-success btn-lg" OnClick="ButtonCargar_Click" Text="Cargar Datos" />
    </p>
    </asp:Content>
