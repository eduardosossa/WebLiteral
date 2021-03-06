using NUnit.Framework;

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
            string num1 = "9";
            string esperado = "Nueve";

            LiteralController lit = new LiteralController();

            //act= ejecucion

            string resultado = lit.NumeroGet(num1);
            
            //assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestNumeroPost()
        {
            //arrange preparacion
            string num1 = "321";
            string esperado = "Trescientos veinte y uno";

            LiteralController lit = new LiteralController();

            //act= ejecucion

            string resultado = lit.NumeroPost(num1);
            
            //assert=verificacion

            Assert.AreEqual(esperado, resultado);
        }
    }
}