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

                GridView1.DataSource = persona.getAll();
                GridView1.DataBind();
            }
        }
    }
}