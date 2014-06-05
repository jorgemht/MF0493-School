<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarCurso.aspx.cs" Inherits="Practica03_MF0493.ListarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista de cursos</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="CourseID" HeaderText="Id del curso" />
        <asp:BoundField DataField="Title" HeaderText="Nombre del curso" />
        <asp:BoundField DataField="Credits" HeaderText="Creditos del curso" />
        <asp:BoundField DataField="DepartmentID" HeaderText="Departamento del curso" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
    </asp:GridView>
</asp:Content>
