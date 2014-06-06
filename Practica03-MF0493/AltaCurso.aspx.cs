using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica03_MF0493
{
    public partial class AltaCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void volverMenu(object sender, EventArgs e)
        {
            Response.Redirect("ListarCurso.aspx", true);
        }

        protected void addPersona(object sender, EventArgs e)
        {
             CourseManager curso = new CourseManager();

             curso.CourseID=Int32.Parse(this.Id_curso.Text);
             curso.Title = this.Nombre_curso.Text;
             curso.Credits = Int32.Parse(this.Creditos_curso.Text);
             curso.DepartmentID= Int32.Parse(this.Departamento_curso.Text);

             int cursoAdd=curso.Add(curso);

             if(cursoAdd!=-1)
             {
                 //TODO-OK
             }
             else
             {
                 //ERROR
             }

             Response.Redirect("Default.aspx", true);
        }

      
     }
}
