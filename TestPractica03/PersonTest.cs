using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestPractica03
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Practica03_MF0493.Models.Person> people = new List<Practica03_MF0493.Models.Person>();
            Practica03_MF0493.PersonManager persona = new Practica03_MF0493.PersonManager();
            people = persona.getAll();
            Assert.AreEqual(people.Count, 44);
        }

        [TestMethod]
        public void getTest()
        {
            Practica03_MF0493.Models.Person people = new Practica03_MF0493.Models.Person();
            //Practica03_MF0493.Person persona = new Practica03_MF0493.Person();

            //persona.get(6);

            people.PersonID = 6;


            Assert.AreEqual(people.FirstName, "Li");
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
