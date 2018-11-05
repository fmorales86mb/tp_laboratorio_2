using System;
using ClasesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Test Unitarios:
//a.Generar al menos dos test unitario que validen Excepciones
//b.Generar al menos uno que valide un valor numérico
//c.Generar al menos uno que valide que no haya valores nulos en algún atributo de las clases dadas.

namespace UnitTest
{
    [TestClass]
    public class ExcepcionesTest
    {
        [TestMethod]
        public void AlumnoRepetidoExceptionTest()
        {
            Alumno a1, a2;
            Jornada j;
            Profesor p;

            p = new Profesor(2, "profe", "sor", "32323232", EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            j = new Jornada(Universidad.EClases.Laboratorio, p);
            a1 = new Alumno(1, "Federico", "Morales", "32386123", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            a2 = new Alumno(1, "Federico2", "Morales2", "32386128", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

            j += a1;
            try
            {
                j += a2;
                Assert.Fail();
            }
            catch (AlumnoRepetidoException e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }            
        }

        [TestMethod]
        public void SinProfesorExceptionTest()
        {
            Universidad universidad;
            Profesor i2;

            i2 = new Profesor(2, "Roberto", "Juarez", "32234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            universidad = new Universidad();
            universidad += i2;

            try
            {
                universidad += Universidad.EClases.Programacion;
                universidad += Universidad.EClases.Laboratorio;
                universidad += Universidad.EClases.Legislacion;
                Assert.Fail();
            }
            catch(SinProfesorException e)
            {
                Assert.IsInstanceOfType(e, typeof(SinProfesorException));
            }
        }
    }
}
