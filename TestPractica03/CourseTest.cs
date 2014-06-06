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
        /// <summary>
        /// Metodo getAllTest(). Se comprueba el número total de cursos en la base de datos.
        /// </summary>
        [TestMethod]
        public void getAllTest()
        {
            CourseManager curso = new CourseManager();

            List<CourseManager> lista = curso.getAll();

            Assert.AreEqual(lista.Count, 13);

        }

        /// <summary>
        /// Método de prueba. Dos pruebas unitarias. Obtenemos un curso a partir de un Id pasado por parámetro.
        /// </summary>
        [TestMethod]
        public void getTest()
        {
            CourseManager curso = new CourseManager();
            CourseManager curso2 = new CourseManager();

            CourseManager cursoResultado=curso.get(1045);
            CourseManager cursoResultado2 = curso.get(1050);


            
            Assert.AreEqual(cursoResultado.Title, "Calculus");
            Assert.AreEqual(cursoResultado2.Title, "Chemistry");
        }

        /// <summary>
        /// Inserta y elimina un elemento de la base de datos.
        /// </summary>
        [TestMethod]
        public void addRemoveTest()
        {

            CourseManager course = new CourseManager();

            course.CourseID = 666;
            course.Credits = 45;
            course.DepartmentID = 2;
            course.Title = "Test";
            

            int idCursoInsertado=course.Add(course);
            bool delete= course.Remove(666);

            Assert.AreEqual(idCursoInsertado, 666);
            Assert.AreEqual(delete, true);
        }
       

    }
}
