using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala {
    [TestClass]
    public class DadoTest {
        [TestMethod]
        public void VerificarTiradaDeDado() {
            Dado dado = new Dado();

            dado.TirarDado();

            Assert.IsTrue(dado.UltimoValor > 0 && dado.UltimoValor < 7);
        }
    }
}
