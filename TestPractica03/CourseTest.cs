using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica03_MF0493.Models;
using System.Collections.Generic;
using Practica03_MF0493;

namespace TestPractica03
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void getAllTest()
        {
           
        }
        [TestMethod]
        public void getTest()
        {
            CourseManager curso = new CourseManager();
            CourseManager curso2 = new CourseManager();

           

            curso.CourseID = 1045;

            
            Assert.AreEqual(curso.Title, "Calculus");
        }
        [TestMethod]
        public void addTest()
        {

            Practica03_MF0493.Models.Person people = new Practica03_MF0493.Models.Person();
            people.FirstName = "Aitor";
            people.LastName = "Tilla";

            Practica03_MF0493.PersonManager persona = new Practica03_MF0493.PersonManager();

            int idPerson = persona.Add(people);

            Assert.AreEqual(people.PersonID, 41);
        }
        [TestMethod]
        public void removeTest()
        {
            Practica03_MF0493.PersonManager persona = new Practica03_MF0493.PersonManager();

            bool delete = persona.Remove(41);
            Assert.AreEqual(delete, true);
        }

    }
}
