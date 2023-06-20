using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala {
    [TestClass]
    public class UsuarioTest {
        [TestMethod]
        public void VerificarIgualdadUsuarios_Ok() {
            // Arrange
            Usuario u1 = new Usuario(1, "nombre1", "apellido1", "1@correo.com", "123clave1");
            Usuario u2 = new Usuario(1, "nombre1", "apellido1", "1@correo.com", "123clave1");

            // Act
            bool rta = u1 == u2;

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarIgualdadUsuarios_Falla() {
            // Arrange
            Usuario u1 = new Usuario(1, "nombre1", "apellido1", "1@correo.com", "123clave1");
            Usuario u2 = new Usuario(2, "nombre2", "apellido2", "2@correo.com", "123clave2");

            // Act
            bool rta = u1 == u2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadUsuariosNulos() {
            // Arrange
            Usuario? u1 = null;
            Usuario? u2 = null;

            // Act
            bool rta = u1! == u2!;

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarIgualdadUsuarioUnoConNull() {
            // Arrange
            Usuario? u1 = null;
            Usuario u2 = new Usuario(2, "nombre2", "apellido2", "2@correo.com", "123clave2");

            // Act
            bool rta = u1! == u2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadUsuarioDosConNull() {
            // Arrange
            Usuario u1 = new Usuario(1, "nombre1", "apellido1", "1@correo.com", "123clave1");
            Usuario? u2 = null;

            // Act
            bool rta = u1 == u2!;

            // Assert
            Assert.IsFalse(rta);
        }
    }
}
