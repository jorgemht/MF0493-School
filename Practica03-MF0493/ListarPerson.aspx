<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarPerson.aspx.cs" Inherits="Practica03_MF0493.ListarPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
    <h1>Lista de alumnos</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="PersonID" HeaderText="Id del alumno" />
        <asp:BoundField DataField="LastName" HeaderText="Nombre del alumno" />
        <asp:BoundField DataField="FirstName" HeaderText="Apellidos del alumno" />
        <asp:BoundField DataField="HireDate" HeaderText="Fecha de alta" />
        <asp:BoundField DataField="EnrollmentDate" HeaderText="Fecha de matricula" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
    </asp:GridView>
</form>
</asp:Content>
