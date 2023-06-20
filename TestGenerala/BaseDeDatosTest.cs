using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala {
    [TestClass]
    public class BaseDeDatosTest {
        [TestMethod]
        public void VerificarConexionABaseDeDatos() {
            // Arrange
            BasesDeDatos db = new BasesDeDatos();

            // Act
            bool rta = db.ProbarConexion();

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarLecturaUsuarios() {
            // Arrange
            BasesDeDatos db = new BasesDeDatos();

            // Act
            List<Usuario> listaLeida = db.ObtenerListaUsuarios();

            // Assert
            Assert.IsTrue(listaLeida != null);
        }

        [TestMethod]
        public void VerificarLecturaJugadores() {
            // Arrange
            BasesDeDatos db = new BasesDeDatos();

            // Act
            List<Jugador> listaLeida = db.ObtenerListaJugadores();

            // Assert
            Assert.IsTrue(listaLeida != null);
        }
    }
}
