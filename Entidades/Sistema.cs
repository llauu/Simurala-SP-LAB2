using System.Diagnostics;

namespace Entidades {
    public static class Sistema {
        private static List<Usuario>? listaUsuarios;
        private static List<Jugador>? listaJugadores;
        private static List<Partida> listaPartidas;
        private static string rutaUsuariosJson;
        private static string rutaJugadoresJson;
        private static string rutaImagenDadoUno;
        private static string rutaImagenDadoDos;
        private static string rutaImagenDadoTres;
        private static string rutaImagenDadoCuatro;
        private static string rutaImagenDadoCinco;
        private static string rutaImagenDadoSeis;


        public static List<Usuario> ListaUsuarios { get => listaUsuarios; }
        public static List<Jugador> ListaJugadores { get => listaJugadores; }
        public static List<Partida> ListaPartidas { get => listaPartidas; }
        public static string RutaImagenDadoUno { get => rutaImagenDadoUno; }
        public static string RutaImagenDadoDos { get => rutaImagenDadoDos; }
        public static string RutaImagenDadoTres { get => rutaImagenDadoTres; }
        public static string RutaImagenDadoCuatro { get => rutaImagenDadoCuatro; }
        public static string RutaImagenDadoCinco { get => rutaImagenDadoCinco; }
        public static string RutaImagenDadoSeis { get => rutaImagenDadoSeis; }

        static Sistema() {
            listaUsuarios = new List<Usuario>();
            listaJugadores = new List<Jugador>();
            listaPartidas = new List<Partida>();

            rutaUsuariosJson = @"..\..\..\..\db\datosUsuarios.json";
            rutaJugadoresJson = @"..\..\..\..\db\datosJugadores.json";
            rutaImagenDadoUno = @"..\..\..\..\Recursos\cara_dados\dados_uno.png";
            rutaImagenDadoDos = @"..\..\..\..\Recursos\cara_dados\dados_dos.png";
            rutaImagenDadoTres = @"..\..\..\..\Recursos\cara_dados\dados_tres.png";
            rutaImagenDadoCuatro = @"..\..\..\..\Recursos\cara_dados\dados_cuatro.png";
            rutaImagenDadoCinco = @"..\..\..\..\Recursos\cara_dados\dados_cinco.png";
            rutaImagenDadoSeis = @"..\..\..\..\Recursos\cara_dados\dados_seis.png";
        }

        /// <summary>
        /// Lee los archivos en donde se encuentran los datos utilizados anteriormente
        /// </summary>
        public static void CargarArchivos() {
            listaUsuarios = Archivos<Usuario>.LeerArchivoJson(listaUsuarios, rutaUsuariosJson);
            listaJugadores = Archivos<Jugador>.LeerArchivoJson(listaJugadores, rutaJugadoresJson);
        }

        /// <summary>
        /// Escribe los datos en archivos json para tener permanencia de ellos
        /// </summary>
        public static void EscribirArchivos() {
            Archivos<Usuario>.EscribirArchivoJson(listaUsuarios, rutaUsuariosJson);
            Archivos<Jugador>.EscribirArchivoJson(listaJugadores, rutaJugadoresJson);
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

        public static bool CrearJugador(string nombre, string apellido, string usuario) {
            bool seCreo = false;

            if (listaUsuarios != null) {
                Jugador jugadorCreado = new Jugador(nombre, apellido, usuario);
                listaJugadores?.Add(jugadorCreado);
                seCreo = true;
            }

            return seCreo;
        }

        public static Partida CrearPartida(Jugador jugador1, Jugador jugador2, Action<Dado[]> DelegadoMostrarDados, Action DelegadoCambioRegistro) {
            Partida? partidaCreada = null;

            if (Validador.ValidarJugadores(jugador1, jugador2)) {
                partidaCreada = new Partida(jugador1, jugador2, DelegadoMostrarDados, DelegadoCambioRegistro);
                listaPartidas.Add(partidaCreada);
                jugador1.PartidaEnCurso = true;
                jugador2.PartidaEnCurso = true;
            }

            return partidaCreada!;
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
