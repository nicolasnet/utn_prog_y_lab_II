using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entidades;
using Excepciones;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException), "Falla el test")]
        public void TestSerializacionDeVotacion()
        {
            // arrange
            SerializarBinaria archivar = new SerializarBinaria();
            Votacion votacion = new Votacion();

            //act
            archivar.Guardar("", votacion);

        }



        /// <summary>
        /// Testear cantidad de invocaciones del evento.
        /// </summary>
        [TestMethod]
        public void InvocacionEvento()
        {
            // arrange
            

            //act
            

            //assert
            
        }
    }
}
