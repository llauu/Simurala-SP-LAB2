using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala {
    [TestClass]
    public class ValidadorTest {
        [TestMethod]
        public void VerificarValidadorCadena_Ok() {
            // Arrange
            string cadena = "Test";

            // Act
            string cadenaValidada = Validador.ValidarCadena(cadena);

            // Assert
            Assert.AreEqual(cadena, cadenaValidada);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VerificarValidadorCadena_Falla() {
            // Arrange
            string cadena = "123";

            // Act
            string cadenaValidada = Validador.ValidarCadena(cadena);

            // Assert
            Assert.AreNotEqual(cadena, cadenaValidada);
        }

        [TestMethod]
        public void VerificarValidadorCorreo_Ok() {
            // Arrange
            string correo = "correo@valido.com";

            // Act
            string correoValidado = Validador.ValidarCorreo(correo);

            // Assert
            Assert.AreEqual(correo, correoValidado);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VerificarValidadorCorreo_Falla() {
            // Arrange
            string correo = "correomal";

            // Act
            string correoValidado = Validador.ValidarCorreo(correo);

            // Assert
            Assert.AreNotEqual(correo, correoValidado);
        }

        [TestMethod]
        public void VerificarValidadorJugador_Ok() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");

            // Act
            bool valido = Validador.ValidarJugadores(j1, j2);

            // Assert
            Assert.IsTrue(valido);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VerificarValidadorJugador_Falla() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");

            j1.PartidaEnCurso = true;

            // Act
            bool valido = Validador.ValidarJugadores(j1, j2);

            // Assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void VerificarValidadorClave_Ok() {
            // Arrange
            string claveValida = "123prueba";

            // Act
            string claveValidada = Validador.ValidarClaveValida(claveValida);

            // Assert
            Assert.AreEqual(claveValida, claveValidada);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VerificarValidadorClave_Falla() {
            // Arrange
            string claveNoValida = "123";

            // Act
            string claveValidada = Validador.ValidarClaveValida(claveNoValida);

            // Assert
            Assert.AreNotEqual(claveNoValida, claveValidada);
        }
    }
}
