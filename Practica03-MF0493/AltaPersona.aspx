<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="Practica03_MF0493.AltaPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <section class="panel panel-default col-md-8 col-md-offset-2">
              <header class="panel-heading text-center">
                   &larr;
                <asp:Button CssClass="btn btn-danger" ID="Button2" runat="server" Text="Volver al menu principal" 
                    OnClientClick="return confirm('¿Estas seguro?');" OnClick="volverMenu" />
                <asp:Button ID="botonEnviar" runat="server" Text="Dar de alta a la persona" CssClass="btn btn-success"
                     OnClick="addPersona" />&rarr;
              </header>  
                  <div class="panel-body">
                  <article class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="label-primary text-center"><h4>Nombre</h4></asp:Label>
                    <asp:TextBox ID="Nombre_alumno" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                             ErrorMessage="El nombre has de escribir, no puede estar vacio" ControlToValidate="Nombre_alumno" CssClass="alert-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidarNombre_alumno" runat="server"
                             ErrorMessage="Solo se admite letras" ValidationExpression="[A-Za-z ]*" CssClass="alert-danger" ControlToValidate="Nombre_alumno"></asp:RegularExpressionValidator>
                  </article>
                  <article class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="label-primary text-center"><h4>Apellidos</h4></asp:Label>
                    <asp:TextBox ID="Apellido_alumno" runat="server"  CssClass="col-md-6 form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Apellido_alumno" CssClass="alert-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidarApellido_alumno" runat="server"
                             ErrorMessage="El apellido has de escribir, no puede estar vacio" ValidationExpression="[A-Za-z ]*" CssClass="alert-danger" ControlToValidate="Apellido_alumno"></asp:RegularExpressionValidator>
                  </article>
                  <article class="form-group">
                    <asp:Label ID="Label3" runat="server" 
                        Text="Label" CssClass="label-primary  text-center"><h4>Fecha del alumno <span class="text-warning">(yyyy-mm-dd)</span></h4></asp:Label>
                    <asp:TextBox ID="Fecha_alta" runat="server" 
                         CssClass="col-md-6 form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidarFechaAlta" runat="server"
                             ErrorMessage="La fecha debe rellenarse" ControlToValidate="Fecha_alta" CssClass="alert-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                             ErrorMessage="La fecha no es valida, debe ser yyyy-mm-dd (ojo el - es necesario y obligatorio) " ValidationExpression="(19|20)[0-9]{2}[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])" CssClass="alert-danger" ControlToValidate="Fecha_alta"></asp:RegularExpressionValidator>
                  </article>
                  <article class="form-group">
                    <asp:Label ID="Label4" runat="server"
                         Text="Label" CssClass="label-primary text-center"><h4>Fecha de matriculacion <span class="text-warning">(yyyy-mm-dd)</span></h4> </asp:Label>
                    <asp:TextBox ID="Fecha_matricula" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validarFechaMatricula" runat="server"
                             ErrorMessage="La fecha debe rellenarse" ControlToValidate="Fecha_matricula" CssClass="alert-danger"></asp:RequiredFieldValidator>                 
                    <asp:RegularExpressionValidator ID="validaFechaMatricula" runat="server"
                             ErrorMessage="La fecha no es valida, debe ser yyyy-mm-dd (ojo el - es necesario y obligatorio)" ValidationExpression="(19|20)[0-9]{2}[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])" CssClass="alert-danger" ControlToValidate="Fecha_matricula"></asp:RegularExpressionValidator>
                    </article>  
                </div> <!-- Fin del panel body -->
            </section> <!-- Fin del panel panel-default -->
        </div> <!-- Fin del row -->
    </div> <!-- Fin del container -->
</form>
</asp:Content>