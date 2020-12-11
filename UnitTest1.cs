using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suma;
namespace Suma.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumar2numeros()
        {
            var sumando1 = 30;
            var sumando2 = 40;
            var total = 70;

            var calculadora = new Calculadora();

            var resultado = calculadora.suma(sumando1, sumando2);
            Assert.AreEqual(total, resultado);
        }
    }
}
