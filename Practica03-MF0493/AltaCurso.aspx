<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaCurso.aspx.cs" Inherits="Practica03_MF0493.AltaCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form id="form1" runat="server">
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-offset-1 col-md-4">
             <asp:Button CssClass="btn btn-lg" ID="btnVolver" runat="server" Text="Volver" OnClientClick="return confirm('¿Estas seguro?');" OnClick="btnVolver_Click" />
         </div>
         <div class="col-md-8 col-md-offset-2">
            <h1 class="text-center">Alta curso</h1>
                <table class="nav-justified table table-hover">
                    <tr>
                        <td>Id del curso</td>
                        <td><asp:TextBox ID="Id_curso" runat="server"></asp:TextBox></td>
                        <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Id_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                             ErrorMessage="Solo se admiten 2 numeros" ValidationExpression="^[0-9]{2}$" CssClass="alert-danger" ControlToValidate="Id_curso"></asp:RegularExpressionValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Nombre del curso</td>
                        <td><asp:TextBox ID="Nombre_curso" runat="server"></asp:TextBox></td>
                        <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Nombre_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                             ErrorMessage="Solo se admite letras" ValidationExpression="[A-Za-z ]*" CssClass="alert-danger" ControlToValidate="Nombre_curso"></asp:RegularExpressionValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Creditos del curso</td>
                        <td><asp:TextBox ID="Creditos_curso" runat="server"></asp:TextBox></td>
                        <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                             ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Creditos_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                             ErrorMessage="Solo se admiten 2 numeros" ValidationExpression="^[0-9]{2}$" CssClass="alert-danger" ControlToValidate="Creditos_curso"></asp:RegularExpressionValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Departamento curso</td>
                        <td><asp:TextBox ID="Departamento_curso" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                 ErrorMessage="El campo no se puede quedar vacio" ControlToValidate="Departamento_curso" CssClass="alert-danger"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                 ErrorMessage="Introduzca un numero de departamento válido (1,2,4,7)" ValidationExpression="^[1,2,4,7]{1}$" CssClass="alert-danger" ControlToValidate="Departamento_curso"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                        
                    <tr>
                        <td colspan="3"><asp:Button CssClass="btn btn-lg btn-success col-md-offset-5" ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" /></td>
                    </tr>
                </table>
            </div>
          </div>
        </div>
    </form>
</asp:Content>
