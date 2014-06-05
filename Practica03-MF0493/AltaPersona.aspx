<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="Practica03_MF0493.AltaPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Alta alumno</h1>
    <form id="form1" runat="server">
        <table class="nav-justified table table-hover">
            <tr>
                <td>Nombre del alumno</td>
                <td><asp:TextBox ID="Nombre_alumno" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td>Apellido del alumno</td>
                <td><asp:TextBox ID="Apellido_alumno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fecha de alta</td>
                <td><asp:TextBox ID="Fecha_alta" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fecha de matriculación</td>
                <td><asp:TextBox ID="Fecha_matricula" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button CssClass="btn btn-lg btn-danger" ID="Button2" runat="server" Text="Cancelar" OnClientClick="return confirm('¿Estas seguro?');" OnClick="Button1_Click" /></td>
                <td><asp:Button CssClass="btn btn-lg btn-success" ID="Button1" runat="server" Text="Enviar" /></td>
            </tr>
        </table>
    </form>
</asp:Content>
