using Practica03_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica03_MF0493
{
    public class Course:ICurso
    {
        /// <summary>
        /// Variable que representa el identificador del curso
        /// </summary>
        private int _CourseID;
        public int CourseID
        {
            get { return this._CourseID; }
            set { this._CourseID = value; }
        }

        /// <summary>
        /// Variable que representa el título del curso
        /// </summary>
        private string _Title;
        public string Title
        {
            get { return this._Title; }
            set { this._Title = value; }
        }

        /// <summary>
        /// Variable que representa a los créditos de un curso.
        /// </summary>
        private int _Credits;
        public int Credits
        {
            get { return this._Credits; }
            set { this._Credits = value; }
        }

        /// <summary>
        /// Variable que representa al identificador de un departamento al que pertenece dicho curso
        /// </summary>
        private int _DepartamentID;
        public int DepartamentID
        {
            get { return this._DepartamentID; }
            set { this._DepartamentID = value; }
        }

        /// <summary>
        /// Constructor por defecto del objeto Curso
        /// </summary>
        public Course()
        {
            this.CourseID = 0;
            this.Credits = 0;
            this.DepartamentID = 0;
            this.Title = " ";
        }

        /// <summary>
        /// Constructor de un objeto curso
        /// </summary>
        /// <param name="id">Id del curso</param>
        /// <param name="cred">Créditos de un curso</param>
        /// <param name="depId">Identificador del departamento al que pertenece un curso</param>
        /// <param name="titulo">Título del curso</param>
        public Course(int id,int cred, int depId,string titulo)
        {
            this.CourseID = id;
            this.Credits = cred;
            this.DepartamentID = depId;
            this.Title = titulo;
        }

        /// <summary>
        /// Método que devuelve si un objeto es igual a otro.
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>True si es igual. False si es null, no es del mismo tipo o algun atributo es diferente.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Course cur = (Course)obj;
            return (this.CourseID==cur.CourseID) && (this.Credits==cur.Credits) && (this.DepartamentID==cur.DepartamentID) && (this.Title==cur.Title);
        }

        /// <summary>
        /// Obtener todos los cursos de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Course> getAll()
        {
            List<Course> datos = new List<Course>();
            try
            {
                using (cntSchool cnt = new cntSchool())
                {
                    var resulta = from cur in cnt.Course

                                  select new Course()
                    {
                        CourseID = cur.CourseID,
                        Credits = cur.Credits,
                        DepartamentID = cur.DepartmentID,
                        Title = cur.Title
                    };

                    datos = resulta.ToList(); 
                }
                return datos;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Devuelve un Curso
        /// </summary>
        /// <param name="CourseID">Identificador del curso</param>
        /// <returns>Objeto curso</returns>
        public Course get(int CourseID)
        {
            Course curso;
            try
            {
                using (cntSchool cnt = new cntSchool())
                {
                    var resulta = from cur in cnt.Course
                                  where cur.CourseID==CourseID
                                  select new Course()
                                  {
                                      CourseID = cur.CourseID,
                                      Credits = cur.Credits,
                                      DepartamentID = cur.DepartmentID,
                                      Title = cur.Title
                                  };

                    curso = resulta.First();
                }
                return curso;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que añade un nuevo curso a la base de datos
        /// </summary>
        /// <param name="p">Objeto curso para añadir</param>
        /// <returns>Identificador del curso</returns>
        public int Add(Course p)
        {
            try
            {
                using (cntSchool cnt = new cntSchool())
                {
                    Practica03_MF0493.Models.Course curso = new  Practica03_MF0493.Models.Course();

                    curso.CourseID = p.CourseID;
                    curso.Credits = p.Credits;
                    curso.DepartmentID = p.DepartamentID;
                    curso.Title = p.Title;

                    cnt.Course.Add(curso);
                    cnt.SaveChanges();

                    return p.CourseID;
                }
            }
            catch
            {
                return -1;
            }
        }


        /// <summary>
        /// Método que elimina un curso de la base de datos
        /// </summary>
        /// <param name="CourseID">Identificador de un curso</param>
        /// <returns>Devuelve true si se ha borrado correctamente. Devuelvo False si no se ha eliminado.</returns>
        public bool Remove(int CourseID)
        {
            try
            {
                using (cntSchool cnt = new cntSchool())
                {
                    var consult = from cur in cnt.Course
                                  where cur.CourseID == CourseID
                                  select cur;


                     Practica03_MF0493.Models.Course curso = consult.First();

                    cnt.Course.Remove(curso);
                    cnt.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}