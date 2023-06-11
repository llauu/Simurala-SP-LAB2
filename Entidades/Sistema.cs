namespace Entidades {
    public static class Sistema {
        private static List<Usuario> listaUsuarios;
        private static List<Jugador> listaJugadores;

        public static List<Usuario> ListaUsuarios { get => listaUsuarios; }
        public static List<Jugador> ListaJugadores { get => listaJugadores; }

        static Sistema() {
            listaUsuarios = new List<Usuario>();
            listaJugadores = new List<Jugador>();

            listaUsuarios.Add(new Usuario("lautaro", "monserrat", "admin@", "123admin"));
        }

        /// <summary>
        /// Permite el inicio de sesion a traves de un correo y una clave iniciada, recorre la lista de usuario previamente cargados para validarlos
        /// </summary>
        /// <param name="correo">Correo ingresado</param>
        /// <param name="clave">Clave ingresada</param>
        /// <returns>Indice donde se encuentra el usuario en la lista de usuarios</returns>
        public static int IniciarSesion(string correo, string clave) {
            int indice = -1;

            if (listaUsuarios != null) {
                foreach (Usuario usuario in listaUsuarios) {
                    if (usuario.ChequearCorreo(correo) && usuario.ChequearClave(clave)) {
                        indice = listaUsuarios.IndexOf(usuario);
                        break;
                    }
                }
            }

            return indice;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static bool RegistrarUsuario(string nombre, string apellido, string correo, string clave) {
            bool seRegistro = false;

            if (listaUsuarios != null) {
                Usuario usuarioRegistrado = new Usuario(nombre, apellido, correo, clave);
                listaUsuarios.Add(usuarioRegistrado);
                seRegistro = true;
            }

            return seRegistro;
        }

        public static bool CrearJugador(string nombre) {
            bool seCreo = false;

            if (listaUsuarios != null) {
                Jugador jugadorCreado = new Jugador(nombre);
                listaJugadores.Add(jugadorCreado);
                seCreo = true;
            }

            return seCreo;
        }













        /// <summary>
        /// Genera un ID numerico entre 100000 y 999999 (incluidos)
        /// </summary>
        /// <returns>El ID generado</returns>
        public static int GenerarIdNumerico() {
            Random rand = new Random();
            int idGenerado;

            idGenerado = rand.Next(100000, 1000000);

            return idGenerado;
        }
    }
}