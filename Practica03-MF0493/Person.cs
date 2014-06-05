﻿using Practica03_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica03_MF0493
{
    public class Person:IPerson
    {
        /// <summary>
        ///  Atributos del objeto Person
        /// </summary>
        private int PersonID;
        private string LastName;
        private string FirstName;
        private DateTime HireDate;
        private DateTime EnrollmentDate;

        public Person()
        {
            this.PersonID++;
            this.LastName = "- desconocido -";
            this.FirstName = "- desconocido -";
            this.HireDate = DateTime.Today;
            this.EnrollmentDate = DateTime.Today;
        }

        /// <summary>
        /// Metodo que nos da un listado de las personas
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
                                   select new Person()
                                   {
                                       PersonID = persona.PersonID,
                                       LastName = persona.LastName,
                                       FirstName = persona.FirstName,
                                       HireDate = (DateTime)persona.HireDate,
                                       EnrollmentDate = (DateTime)persona.EnrollmentDate,
                                   };

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
        /// Metodo que nos busca una persona
        /// </summary>
        /// <param name="PersonID">Recibe el ID de la persona y lo busca</param>
        /// <returns>Devuelve la persona si todo es ok, si no devuelve un exception</returns>
        public Person get(int PersonID)
        {
            Person xpersona = new Person(); // Me creo un objeto de tipo persona
            try
            {
                // Creamos una conexion a la bd
                using (cntSchool db = new cntSchool())
                {
                    // Realizamos una consulta, donde vamos a buscar a una persona por su id
                    var consulta = from persona in db.Person where persona.PersonID == PersonID
                                   select new Person
                                   {
                                       PersonID = persona.PersonID,
                                       LastName = persona.LastName,
                                       FirstName = persona.FirstName,
                                       HireDate = (DateTime)persona.HireDate,
                                       EnrollmentDate = (DateTime)persona.EnrollmentDate,
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
        public int Add(Practica03_MF0493.Models.Person p)
        {
            try
            {
                // Creamos una conexion a la bd
                using (cntSchool db = new cntSchool())
                {
                   
                    db.Person.Add(p);
                    db.SaveChanges();
                    return p.PersonID;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }        
        }
        /// <summary>
        /// Metodo que se encarga de eliminar un objeto persona.
        /// </summary>
        /// <param name="PersonID">Recibe el ID de la persona que se va a eliminar</param>
        /// <returns>Devuelve true </returns>
        public bool Remove(int PersonID)
        {
            Person xpersona = new Person(); // Me creo un objeto de tipo persona
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


        public int Add(Person p)
        {
            throw new NotImplementedException();
        }
    }
}