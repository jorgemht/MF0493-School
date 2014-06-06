<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaCurso.aspx.cs" Inherits="Practica03_MF0493.AltaCurso" %>
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
                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="text-center"><h4>Id del curso</h4></asp:Label>
                    <asp:TextBox ID="Id_curso" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Id_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                             ErrorMessage="Solo se admiten 2 numeros" ValidationExpression="^[0-9]{2}$" CssClass="alert-danger" ControlToValidate="Id_curso"></asp:RegularExpressionValidator>
                  </article>

                  <article class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-center"><h4>Nombre del curso</h4></asp:Label>
                    <asp:TextBox ID="Nombre_curso" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Nombre_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                             ErrorMessage="Solo se admite letras" ValidationExpression="[A-Za-z ]*" CssClass="alert-danger" ControlToValidate="Nombre_curso"></asp:RegularExpressionValidator>
                  </article>

                  <article class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Label" CssClass="text-center"><h4>Creditos del curso</h4></asp:Label>
                   <asp:TextBox ID="Creditos_curso" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Creditos_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                             ErrorMessage="Solo se admiten 2 numeros" ValidationExpression="^[0-9]{2}$" CssClass="alert-danger" ControlToValidate="Creditos_curso"></asp:RegularExpressionValidator>
                  </article>

                  <article class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Label" CssClass="text-center"><h4>Departamento del curso</h4></asp:Label>
                    <asp:TextBox ID="Departamento_curso" runat="server" CssClass="col-md-6 form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                 ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Departamento_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                 ErrorMessage="Introduzca un numero de departamento válido (1,2,4,7)" ValidationExpression="^[1,2,4,7]{1}$" CssClass="alert-danger" ControlToValidate="Departamento_curso"></asp:RegularExpressionValidator>

                  </article>  
                </div> <!-- Fin del panel body -->
            </section> <!-- Fin del panel panel-default -->
        </div> <!-- Fin del row -->
    </div> <!-- Fin del container -->
</form>
</asp:Content>
