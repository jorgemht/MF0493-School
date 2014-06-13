using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Practica03_MF0493;
using Practica03_MF0493.Models;

namespace TestPractica03
{
    [TestClass]
    public class PersonManagerTest
    {

        [TestMethod]
        public void getAllTest()
        {
            List<Person> pers = new List<Person>();
            PersonManager x = new PersonManager();

            pers = x.getAll();

            int totalPersonas = pers.Count;

            // Compruebo que la lista me de el total de los registros de mi BD,
            // en mi caso es 36
            Assert.AreEqual(totalPersonas, 36);

            // Vamos hacerlo mas cool, añado una persona. Si la añado debo 37.
            // Si luego la borro, deberia tener 35. 

            Person perso = new Person();
            perso.FirstName = "Jorge";
            perso.LastName = "Moreno";

            PersonManager personanueva = new PersonManager();
            // Guardamos el id, para despues borrar el objeto
            int id = personanueva.Add(perso);

            pers = personanueva.getAll();
            // Incremento el total personas un valor
            int nuevoTotal = pers.Count; totalPersonas++; 
            Assert.AreEqual(totalPersonas, nuevoTotal);

            // Con el id de arriba eliminamos el objeto creado
            bool delete = personanueva.Remove(id);
            pers = personanueva.getAll();
            // Decremento el total personas un valor
            int NuevoTotal = pers.Count; totalPersonas--; 
            Assert.AreEqual(totalPersonas, NuevoTotal);

        }

        [TestMethod]
        public void getTest()
        {
            PersonManager uno = new PersonManager();
            PersonManager dos = new PersonManager();

            PersonManager unoResult = uno.get(6);
            PersonManager dosResult = dos.get(7);

            Assert.AreEqual(unoResult.lastname, "Li");
            Assert.AreEqual(unoResult.firstname, "Yan");
        }

        [TestMethod]
        public void addTest()
        {

            Person p = new Person();
            p.FirstName = "Jorge";
            p.LastName = "Moreno";

            PersonManager persona = new PersonManager();
            int id = persona.Add(p);
            Assert.AreNotEqual(id, 828128182012801280);

            bool elimina = persona.Remove(id);

        }

        [TestMethod]
        public void removeTest()
        {
            Person p = new Person();
            p.FirstName = "Jorge";
            p.LastName = "Moreno";

            PersonManager persona = new PersonManager();


            int id = persona.Add(p);

            bool elimina = persona.Remove(id);
            Assert.AreEqual(elimina, true);
        }


    }
}
