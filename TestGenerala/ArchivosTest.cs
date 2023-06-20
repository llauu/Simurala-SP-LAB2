using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala {
    [TestClass]
    public class ArchivosTest {
        [TestMethod]
        public void VerificarEscrituraYLectura() {
            // Arrange
            List<string> listaEscrita = new List<string>();
            List<string>? listaLeida = new List<string>();

            // Act
            listaEscrita.Add("Hola");
            Archivos<string>.EscribirArchivoJson(listaEscrita, "test.json");
            listaLeida = Archivos<string>.LeerArchivoJson(listaLeida, "test.json");

            // Assert
            Assert.IsTrue(listaLeida != null);
            Assert.AreEqual(listaEscrita[0], listaLeida[0]);
        }
    }
}
