<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ArchivosXML.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Leer datos del Json</h2>    
    <p>
        <asp:GridView ID="GridViewUniversidades" runat="server" OnSelectedIndexChanged="GridViewUniversidades_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:GridView ID="GridViewAlumnos" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;<asp:Label ID="LabelNombre" runat="server" Text="Nombre"></asp:Label>
        <span style="background-color: #FFFFFF">&nbsp;<asp:TextBox ID="TextBoxNombre" runat="server" Width="182px"></asp:TextBox>
&nbsp;<asp:Button ID="ButtonGuardar" runat="server" CssClass="btn btn-success btn-sm" OnClick="ButtonGuardar_Click" Text="Guaradar Cambio" />
        </span>
    </p>
    <p>
        <asp:Button ID="ButtonEliminar" runat="server" CssClass="btn btn-danger btn-lg"  Text="Eliminar Dato" OnClick="ButtonEliminar_Click" />
        <asp:Button ID="ButtonEditar" runat="server" CssClass="btn btn-warning btn-lg"  Text="Editar Dato" OnClick="ButtonEditar_Click" />
    </p>
    </asp:Content>
