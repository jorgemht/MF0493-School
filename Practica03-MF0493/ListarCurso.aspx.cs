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
            GridView1.DataSource = curso.getAll();
            GridView1.DataBind();


        }
    }
}