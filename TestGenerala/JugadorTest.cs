namespace TestGenerala {
    [TestClass]
    public class JugadorTest {
        [TestMethod]
        public void VerificarIgualdadJugadores_Ok() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario1", "nombre1", "apellido1");

            // Act
            bool rta = j1 == j2;

            // Assert
            Assert.IsTrue(rta);
        }


        [TestMethod]
        public void VerificarIgualdadJugadores_Falla() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre1", "apellido1");

            // Act
            bool rta = j1 == j2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadJugadoresNulos() {
            // Arrange
            Jugador? j1 = null;
            Jugador? j2 = null;

            // Act
            bool rta = j1! == j2!;

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarIgualdadJugadorUnoConNull() {
            // Arrange
            Jugador? j1 = null;
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");

            // Act
            bool rta = j1! == j2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadJugadorDosConNull() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador? j2 = null;

            // Act
            bool rta = j1 == j2!;

            // Assert
            Assert.IsFalse(rta);
        }
    }
}