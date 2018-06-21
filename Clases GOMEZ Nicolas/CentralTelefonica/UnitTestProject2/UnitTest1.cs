using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaAbstracta;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InicializacionListaLlamadas()
        {
            // arrange
            Centralita c = new Centralita("Nombre");
            
            //act
            object lista = c.Llamadas;

            //assert
            Assert.IsNotNull(lista);
        }


        [TestMethod]
        [ExpectedException(typeof(CentralitaException), "Falla el test")]
        public void TestExceptionLocal()
        {
            // arrange
            Centralita c = new Centralita("Nombre");

            Local l1 = new Local("Wilde", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 30, "Rosario", 2.21f);
            Local l3 = new Local("Wilde", 10, "Rosario", 5.23f);
            //Exception ejemplo = null;
            //Exception ejemplo1 = null;

            //act
            c = c + l1;
            c += l2;
            c += l3;

            //Lo que sigue es como se me ocurrio a mi, pero queda mas prolijo
            // con la etiqueta que agregue arriba, la cual busca si sale o no la exception
            
            /*
            try
            {
                c += l2;
            }
            catch (CentralitaException e)
            {
                ejemplo1 = e;
            }

            try
            {
                c += l3;
            }
            catch (CentralitaException e)
            {
                ejemplo = e;
            }

            //assert
            Assert.IsNotNull(ejemplo);
            Assert.IsNull(ejemplo1);
            */
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException), "Falla el test")]
        public void TestExceptionProvincial()
        {
            Centralita c = new Centralita("Nombre");

            Provincial l1 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_2, 21, "Bernal");

            c = c + l1;
            c += l2;
        }


        [TestMethod]
        public void Igualdad()
        {
            Provincial l1 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_2, 21, "Bernal");

            Local l3 = new Local("Morón", 10, "Bernal", 5.23f);
            Local l4 = new Local("Morón", 20, "Bernal", 5.21f);

            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(l1 == l3);
            Assert.IsFalse(l1 == l4);
            Assert.IsFalse(l2 == l3);
            Assert.IsFalse(l2 == l4);
            Assert.IsTrue(l3 == l4);         
        }
    }
}
