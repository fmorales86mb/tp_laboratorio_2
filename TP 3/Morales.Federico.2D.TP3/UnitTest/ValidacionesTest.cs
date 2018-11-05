using System;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EntidadesAbstractas.Persona;

namespace UnitTest
{
    [TestClass]
    public class ValidacionesTest
    {
        [TestMethod]
        public void ValorNuloEnAtributo()
        {
            Alumno a;

            a = new Alumno(1, null, "Morales", "32386123", ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            
            Assert.IsNotNull(a.Nombre);
        }

        [TestMethod]
        public void ValidacionNumero ()
        {
            Alumno a;

            a = new Alumno(1, null, "Morales", "32386123", ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            try
            {
                a.Dni = -2;
                Assert.Fail();
            }
            catch(Exception)
            {
                Assert.AreNotEqual(-2, a.Dni);
            }

            Assert.IsNotNull(a.Nombre);
        }
    }
}
