using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.SymbolStore;
using TP2_Punto2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrenge
            Persona persona1 = new Persona("Gonzalo Cainzo", 30, 34546344, 'H', 80, 167);
            Persona persona2 = new Persona("Mariela",67,1243235,'M',60,160);
            Persona persona3 = new Persona("Gordo Ventilador ", 5, 572323451, 'f', 20, 120);
            Persona persona4 = new Persona("Feminista Promedio", 25,5345345,'N',90,160);
            // act
            bool mayoria1 = persona1.MayordeEdad();
            bool mayoria2= persona2.MayordeEdad();
            bool mayoria3 = persona3.MayordeEdad();

            int mediciondepeso = persona1.IMC();
            int mediciondepeso2 = persona2.IMC();
            int mediciondepeso3 = persona3.IMC();

            char sexovalidado = persona1.Validarsexo();
            char sexovalidado2 = persona2.Validarsexo();
            char sexovalidado3 = persona3.Validarsexo();
            char sexovalidado4 = persona4.Validarsexo();




            //assert
            Assert.IsTrue(mayoria1);
            Assert.IsTrue(mayoria2);
            Assert.IsFalse(mayoria3);
            Assert.AreEqual(1, mediciondepeso);
            Assert.AreEqual(0, mediciondepeso2);
            Assert.AreEqual(-1, mediciondepeso3);
            Assert.AreEqual('H',sexovalidado);
            Assert.AreEqual('M', sexovalidado2);
            Assert.AreEqual('H', sexovalidado3);
            Assert.AreEqual('N', sexovalidado4);
            



        }
    }
}
