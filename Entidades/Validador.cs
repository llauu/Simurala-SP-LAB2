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

        public static string ValidarClaveValida(string clave) {
            if (string.IsNullOrEmpty(clave) || clave.Length < 8) {
                throw new Exception("Clave no valida.");
            }

            return clave;
        }
        
        public static int ValidarNumeroPositivo(int numero) {
            if (!(numero > 0 && numero < 100000)) {
                throw new Exception("Campos numericos no validos.");
            }

            return numero;
        }


        public static float ValidarFlotantePositivo(float numero) {
            if (!(numero > 0 && numero < 100000)) {
                throw new Exception("Campos numericos no validos.");
            }

            return numero;
        }
    }
}
