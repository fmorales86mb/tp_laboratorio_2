using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestCorreo
{
    [TestClass]
    public class UnitTestCorreo
    {
        /// <summary>
        /// Verifica que la lista de Paquetes del Correo esté instanciada.
        /// </summary>
        [TestMethod]
        public void TestListaPaquetesInstanaciada()
        {
            Correo correo = new Correo();

            Assert.IsNotNull(correo.Paquetes);
        }

        /// <summary>
        /// Verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID.
        /// </summary>
        [TestMethod]
        public void TestOperadorSuma()
        {
            Correo correo = new Correo();
            Paquete p1 = new Paquete("dir1", "123");
            Paquete p2 = new Paquete("dir2", "123");

            correo += p1;

            try
            {
                correo += p2;
            }
            catch (TrackingIdRepetidoExeption)
            {
                
            }
            catch(Exception)
            {
                Assert.Fail();
            }

            Assert.IsTrue(correo.Paquetes.Count < 2);
        }
    }
}
