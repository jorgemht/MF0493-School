<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="Practica03_MF0493.AltaPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <asp:Button CssClass="btn btn-lg" ID="Button2" runat="server" Text="Volver" OnClientClick="return confirm('¿Estas seguro?');" OnClick="Button1_Click" />
            <section class="panel panel-default col-md-8 col-md-offset-2">
              <header class="panel-heading text-center">Dar de alta una persona</header>
                <div class="panel-body">
                  <article class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="label-primary text-center"><h4>Nombre del alumno</h4></asp:Label>
                    <asp:TextBox ID="Nombre_alumno" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                  </article>
                    <br /><br />
                  <article class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="label-primary text-center"><h4>Apellidos del alumno</h4></asp:Label>
                    <asp:TextBox ID="Apellido_alumno" runat="server"  CssClass="col-md-6 form-control"></asp:TextBox>
                  </article>
                     <br /><br />
                  <article class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Label" CssClass="label-primary  text-center"><h4>Fecha del alumno</h4></asp:Label>
                    <asp:TextBox ID="Fecha_alta" runat="server"  CssClass="col-md-6 form-control"></asp:TextBox>
                  </article>
                     <br /><br />
                  <article class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Label" CssClass="label-primary text-center"><h4>Fecha de matriculacion</h4></asp:Label>
                    <asp:TextBox ID="Fecha_matricula" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                  </article>  
                    <br/><br/>
                    <asp:Button CssClass="btn btn-lg btn-success col-md-offset-5" ID="Button1" runat="server" Text="Enviar" />
                </div> <!-- Fin del panel body -->
            </section> <!-- Fin del panel panel-default -->
        </div> <!-- Fin del row -->
    </div> <!-- Fin del container -->
</form>
</asp:Content>
