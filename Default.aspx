<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArchivosXML._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ejemplo de Escritura de archivo Json</h1>
        <p class="lead">Una universidad contendrá muchos alumnos.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Universidad</h2>
            <p>Ingrese el nombre de la Universidad
                <asp:TextBox ID="TextBoxUniversidad" runat="server" Width="298px"></asp:TextBox>
            </p>
            <h2>Estudiantes</h2>
            <p>
                Ingrese el nombre de los estudiantes
                <asp:TextBox ID="TextBoxAlumno" runat="server" Width="291px"></asp:TextBox>
&nbsp;
                <asp:Button ID="ButtonAlumno" runat="server" CssClass="bg-primary" Text="Ingresar Alumno" Width="151px" OnClick="ButtonAlumno_Click" />
            </p>
            <p>
                Total de alumnos ingresados:
                <asp:Label ID="LabelTotalAlumnos" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-success btn-lg" Text="Ingresar datos de la Universidad" OnClick="Button1_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
