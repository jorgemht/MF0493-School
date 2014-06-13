using Practica03_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica03_MF0493
{
    public class PersonManager:IPerson
    {
        /// <summary>
        ///  Atributos del objeto Person Manager
        /// </summary>
        private int PersonID;
        private string LastName;
        private string FirstName;
        private DateTime HireDate;
        private DateTime EnrollmentDate;

        /// <summary>
        /// Constructor que me inicializa el objeto con unos valores por defecto.
        /// </summary>
        public PersonManager()
        {
            this.PersonID++;
            this.LastName = "- desconocido -";
            this.FirstName = "- desconocido -";
            this.HireDate = DateTime.Today;
            this.EnrollmentDate = DateTime.Today;
        }
        /// <summary>
        /// Metodos get y set
        /// </summary>
        public string lastname
        {
            get { return this.LastName; }
            set { this.LastName = value; }
        }
        public string firstname
        {
            get { return this.FirstName; }
            set { this.FirstName = value; }
        }

        /***** Fin de los metodos get y set *****/

        /// <summary>
        /// Metodo que nos lista la tabla personas de nuestra BD
        /// </summary>
        /// <returns></returns>
        public List<Person> getAll()
        {
            List<Person> person = new List<Person>();
            try
            {
                using (cntSchool db = new cntSchool())
                {
                    var consulta = from persona in db.Person
                                   select persona;

                    person = consulta.ToList();
                }
                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo que nos busca una persona a partir de su ID
        /// </summary>
        /// <param name="PersonID">Recibe el ID de la persona y lo busca</param>
        /// <returns>Devuelve la persona si todo es ok, si no devuelve un exception</returns>
        public PersonManager get(int PersonID)
        {
            PersonManager xpersona = new PersonManager(); // Me creo un objeto de tipo persona
            try
            {
                // Creamos una conexion a la bd
                using (cntSchool db = new cntSchool())
                {
                    // Realizamos una consulta, donde vamos a buscar a una persona por su id
                    var consulta = from persona in db.Person where persona.PersonID == PersonID
                                   select new PersonManager
                                   {
                                       PersonID = persona.PersonID,
                                       LastName = persona.LastName,
                                       FirstName = persona.FirstName,
                                   };

                    xpersona = consulta.First();
                }
                return xpersona;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        /// <summary>
        /// Metodo que añade un objeto de tipo persona
        /// </summary>
        /// <param name="p">Recibe un objeto de tipo persona</param>
        /// <returns>Devuelve el ID de la persona, y si hay un fallo -1</returns>
        public int Add(Person p)
       /*Como tenemos dos clases llamadas Person, c# no sabe que tipo de objeto le estamos pasando, 
            por eso tenemos que especificarle el namespace, que en nuestro caso es el namespace del objeto que hay en Models*/
        {
            try
            {
                // Creamos una conexion a la bd
                using (cntSchool db = new cntSchool())
                {
                    db.Person.Add(p); // Añadimos el objeto a la BD
                    db.SaveChanges(); // Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                return -1; // Si no se ha podido agregar a la persona, devolvemos -1.
            }

            return p.PersonID; // Si todo ha ido ok, devolvemos el ID de la persona
        }
        /// <summary>
        /// Metodo que se encarga de eliminar un objeto persona.
        /// </summary>
        /// <param name="PersonID">Recibe el ID de la persona que se va a eliminar</param>
        /// <returns>Devuelve true </returns>
        public bool Remove(int PersonID)
        {
            PersonManager xpersona = new PersonManager();
            // Me creo un objeto de tipo persona
            try
            {
                // Creamos una conexion a la bd
                using (cntSchool db = new cntSchool())
                {
                    // Realizamos una consulta, donde vamos a buscar a una persona por su id
                    var consulta = from persona in db.Person where persona.PersonID == PersonID
                                   select persona;

                     Practica03_MF0493.Models.Person personas = consulta.First();

                     db.Person.Remove(personas);
                     db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
               return false;
            }           
        }


        List<PersonManager> IPerson.getAll()
        {
            throw new NotImplementedException();
        }

        public int Add(PersonManager p)
        {
            throw new NotImplementedException();
        }
    }
}
