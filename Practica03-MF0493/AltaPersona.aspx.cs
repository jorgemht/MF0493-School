using Practica03_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica03_MF0493
{
    public partial class AltaPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addPersona(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                this.Validate();
                if (this.IsValid)
                {
                    Person persona = new Person();

                    persona.PersonID++;
                    persona.FirstName = this.Nombre_alumno.Text;
                    persona.LastName = this.Apellido_alumno.Text;
                    persona.HireDate = Convert.ToDateTime(this.Fecha_alta.Text);
                    persona.EnrollmentDate = Convert.ToDateTime(this.Fecha_matricula.Text);

                    PersonManager p = new PersonManager(); // Me creo un objeto de tipo persona

                    int PersonID = p.Add(persona); // Al objeto p le voy añadir el objeto persona

                    Response.Redirect("Default.aspx");
                
                }
            }
            Response.Redirect("Default.aspx", true);
        }

        protected void volverMenu(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }
    }
}
