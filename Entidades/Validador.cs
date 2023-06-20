using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public static class Validador {
        public static string ValidarCadena(string cadena) {
            if (string.IsNullOrEmpty(cadena) || cadena.All(char.IsDigit)) {
                throw new Exception("Campos de texto no validos.");
            }

            return cadena;
        }

        public static string ValidarCorreo(string correo) {
            if (string.IsNullOrEmpty(correo) || !correo.Contains('@')) {
                throw new Exception("Correo no valido.");
            }

            if(!ValidarCorreoUnico(correo)) {
                throw new Exception("Correo ya registrado.");
            }

            return correo;
        }

        public static bool ValidarCorreoUnico(string correo) {
            bool correoUnico = true;

            if (Sistema.ListaUsuarios != null) {
                foreach (Usuario usuario in Sistema.ListaUsuarios) {
                    if (usuario.Correo == correo) {
                        correoUnico = false;
                        break;
                    }
                }
            }

            return correoUnico;
        }

        public static bool ValidarIdPartidaUnico(int id) {
            bool idUnico = true;

            if (Sistema.ListaPartidas != null) {
                foreach (Partida partida in Sistema.ListaPartidas) {
                    if (id == partida.Id) {
                        idUnico = false;
                        break;
                    }
                }
            }

            return idUnico;
        }

        public static bool ValidarIdUsuarioUnico(int id) {
            bool idUnico = true;

            if (Sistema.ListaUsuarios != null) {
                foreach (Usuario usuario in Sistema.ListaUsuarios) {
                    if (id == usuario.Id) {
                        idUnico = false;
                        break;
                    }
                }
            }

            return idUnico;
        }

        public static bool ValidarJugadores(Jugador jugador1, Jugador jugador2) {
            bool jugadoresValidos = true;

            if(jugador1 == jugador2) {
                jugadoresValidos = false;
                throw new Exception("No se pueden seleccionar dos jugadores iguales.");
            }

            if(jugador1.PartidaEnCurso || jugador2.PartidaEnCurso) {
                jugadoresValidos = false;
                throw new Exception("No se pueden seleccionar jugadores con partidas en curso.");
            }

            return jugadoresValidos;
        }

        public static string ValidarUsuarioDeJugadorUnico(string usuario) {
            if (Sistema.ListaJugadores != null) {
                foreach (Jugador jugador in Sistema.ListaJugadores) {
                    if (usuario == jugador.Usuario) {
                        throw new Exception("Usuario no disponible.");
                    }
                }
            }

            return usuario;
        }

        public static string ValidarClaveValida(string clave) {
            if (string.IsNullOrEmpty(clave) || clave.Length < 8) {
                throw new Exception("Clave no valida.");
            }

            return clave;
        }
    }
}
