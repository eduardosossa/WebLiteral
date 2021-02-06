using NUnit.Framework;
using proyectoliteral.Controllers;

namespace UNITest
{
    public class TestLiteral
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestNumeroGet()
        {
            //arrange preparacion
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();

            //act= ejecucion

            string resultado = lit.NumeroGet(num1);

            //assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        
        public void TestNumeroPost()
        {
            //arrange preparacion
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();

            //act= ejecucion

            string resultado = lit.NumeroPost(num1);

            //assert=verificacion

            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestNumeroGet2()
        {
            //arrange preparacion
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();

            //act= ejecucion

            string resultado = lit.NumeroGet(num1);

            //assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        public void TestNumeroPost2()
        {
            //arrange preparacion
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();

            //act= ejecucion

            string resultado = lit.NumeroPost(num1);

            //assert=verificacion

            Assert.AreEqual(esperado, resultado);
        }
    }
}