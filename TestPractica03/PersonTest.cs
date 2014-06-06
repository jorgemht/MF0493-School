using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Practica03_MF0493;
using Practica03_MF0493.Models;

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
            Assert.AreEqual(people.Count, 46);
        }

        [TestMethod]
        public void getTest()
        {
            PersonManager people = new PersonManager();
           

            Person personaPrueba= people.get(6);

            Assert.AreEqual(personaPrueba.FirstName, "Li");
        }

        [TestMethod]
        public void addRemoveTest()
        {

            Practica03_MF0493.Models.Person people = new Practica03_MF0493.Models.Person();
            people.FirstName = "Aitor";
            people.LastName = "Tilla";
            

            Practica03_MF0493.PersonManager persona = new Practica03_MF0493.PersonManager();

            int idPerson = persona.Add(people);

            Assert.AreEqual(people.PersonID, 53);

            bool eliminado=persona.Remove(53);

            Assert.AreEqual(eliminado, true);
        }

       
    }
}
