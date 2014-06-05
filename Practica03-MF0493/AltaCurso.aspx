<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaCurso.aspx.cs" Inherits="Practica03_MF0493.AltaCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Alta curso</h1>
    <form id="form1" runat="server">
        <table class="nav-justified table table-hover">
            <tr>
                <td>Id del curso</td>
                <td><asp:TextBox ID="Id_curso" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td>Nombre del curso</td>
                <td><asp:TextBox ID="Nombre_curso" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Creditos del curso</td>
                <td><asp:TextBox ID="Creditos_curso" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Departamento curso</td>
                <td><asp:TextBox ID="Departamento_curso" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button CssClass="btn btn-lg btn-danger" ID="Button2" runat="server" Text="Cancelar" OnClientClick="return confirm('¿Estas seguro?');" OnClick="Button1_Click" /></td>
                <td><asp:Button CssClass="btn btn-lg btn-success" ID="Button1" runat="server" Text="Enviar" /></td>
            </tr>
        </table>
    </form>
</asp:Content>
