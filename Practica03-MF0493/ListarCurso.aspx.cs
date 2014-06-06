using Practica03_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica03_MF0493
{
    public partial class ListarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CourseManager curso = new CourseManager(); 
            GridView2.DataSource = curso.getAll();
            GridView2.DataBind();
            var count = curso.getAll().Count;
            this.contador.Text = Convert.ToString(count);


        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string codigo = e.Values["CourseID"].ToString();

            CourseManager curso = new CourseManager();
            curso.Remove(Convert.ToInt32(codigo));
            this.GridView2.DataSource = curso.getAll();
            this.GridView2.DataBind();
        }

    }
}
