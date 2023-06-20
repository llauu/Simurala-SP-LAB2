using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala {
    [TestClass]
    public class PartidaTest {
        Action<Dado[]>? DelegadoMostrarDados;
        Action? DelegadoCambioRegistro;

        [TestMethod]
        public void VerificarIgualdadPartidas_Ok() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");
            Partida p1 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);
            Partida p2 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);

            // Act
            bool rta = p1 == p2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadPartidas_Falla() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");
            Partida p1 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);
            Partida p2 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);

            // Act
            bool rta = p1 == p2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadPartidasNulas() {
            // Arrange
            Partida? p1 = null;
            Partida? p2 = null;

            // Act
            bool rta = p1! == p2!;

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarIgualdadPartidaUnoConNull() {
            // Arrange
            Partida? p1 = null;
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");
            Partida p2 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);

            // Act
            bool rta = p1! == p2;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarIgualdadPartidaDosConNull() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");
            Partida p1 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);
            Partida? p2 = null;

            // Act
            bool rta = p1 == p2!;

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarJugabilidadDePartida() {
            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");
            Partida p1 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);

            // Act
            p1.JugarPartida();

            // Assert
            Assert.IsTrue(p1.UsuarioGanador == j1.Usuario || p1.UsuarioGanador == j2.Usuario || p1.UsuarioGanador == "Empate");
        }

        [TestMethod]
        public void VerificarTurnoDePartida() {
            bool cambioValor = true;

            // Arrange
            Jugador j1 = new Jugador("usuario1", "nombre1", "apellido1");
            Jugador j2 = new Jugador("usuario2", "nombre2", "apellido2");
            Partida p1 = new Partida(j1, j2, DelegadoMostrarDados!, DelegadoCambioRegistro!);

            // Act
            p1.JugarTurno(j1);

            foreach(Dado dado in p1.Dados) {
                if(dado.UltimoValor == 0) {
                    cambioValor = false;
                    break;
                }
            }

            // Assert
            Assert.IsTrue(cambioValor);
        }
    }
}
