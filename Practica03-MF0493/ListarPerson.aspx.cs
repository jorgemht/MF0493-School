using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica03_MF0493
{
    public partial class ListarPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                PersonManager persona = new PersonManager();
                this.GridView1.DataSource = persona.getAll();
                this.GridView1.DataBind();
                var count = persona.getAll().Count;
                this.contador.Text = Convert.ToString(count);
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string codigo = e.Values["PersonID"].ToString();

            Practica03_MF0493.PersonManager persona = new Practica03_MF0493.PersonManager();
            persona.Remove(Convert.ToInt32(codigo));
            this.GridView1.DataSource = persona.getAll();
            this.GridView1.DataBind();
        }

    }
}