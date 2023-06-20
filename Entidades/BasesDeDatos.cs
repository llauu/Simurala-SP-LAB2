using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Entidades {
    public class BasesDeDatos {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand? comando;
        private SqlDataReader? lector;

        static BasesDeDatos() {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @".";
            builder.IntegratedSecurity = true;
            //builder.UserID = "usuario";
            //builder.Password = "clave";
            builder.InitialCatalog = "Monserrat.Lautaro.TP2";

            BasesDeDatos.cadena_conexion = builder.ConnectionString;
        }

        public BasesDeDatos() {
            this.conexion = new SqlConnection(BasesDeDatos.cadena_conexion);
        }

        public bool ProbarConexion() {
            bool rta = true;

            try {
                this.conexion.Open();
            }
            catch (Exception) {
                rta = false;
            }
            finally {
                if (this.conexion.State == ConnectionState.Open) {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public List<Usuario> ObtenerListaUsuarios() {
            List<Usuario> lista = new List<Usuario>();

            try {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT id, nombre, apellido, correo, clave FROM Usuarios";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                // se repite por cada registro que tenga la base de datos
                while (lector.Read()) {
                    int id = lector.GetInt32(0);
                    string nombre = lector.GetString(1);
                    string apellido = lector.GetString(2);
                    string correo = lector.GetString(3);
                    string clave = lector.GetString(4);

                    Usuario usuario = new Usuario(id, nombre, apellido, correo, clave);

                    lista.Add(usuario);
                }

                lector.Close();
            }
            catch (Exception) {
                throw;
            }
            finally {
                if (this.conexion.State == ConnectionState.Open) {
                    this.conexion.Close();
                }
            }

            return lista;
        }


        public bool AgregarUsuario(Usuario param) {
            bool rta = true;

            try {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.Id);
                this.comando.Parameters.AddWithValue("@nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", param.Apellido);
                this.comando.Parameters.AddWithValue("@correo", param.Correo);
                this.comando.Parameters.AddWithValue("@clave", param.Clave);

                string sql = "INSERT INTO Usuarios ";
                sql += "(id, nombre, apellido, correo, clave) ";
                sql += "VALUES (@id, @nombre, @apellido, @correo, @clave);";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0) {
                    rta = false;
                }
            }
            catch (Exception) {
                rta = false;
                throw;
            }
            finally {
                if (this.conexion.State == ConnectionState.Open) {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public List<Jugador> ObtenerListaJugadores() {
            List<Jugador> lista = new List<Jugador>();

            try {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT usuario, nombre, apellido, partidasGanadas, puntajeEnTotal FROM Jugadores";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                // se repite por cada registro que tenga la base de datos
                while (lector.Read()) {
                    string usuario = lector.GetString(0);
                    string nombre = lector.GetString(1);
                    string apellido = lector.GetString(2);
                    int partidasGanadas = lector.GetInt32(3);
                    int puntajeEnTotal = lector.GetInt32(4);

                    Jugador jugador = new Jugador(usuario, nombre, apellido, partidasGanadas, puntajeEnTotal);

                    lista.Add(jugador);
                }

                lector.Close();
            }
            catch (Exception) {
                throw;
            }
            finally {
                if (this.conexion.State == ConnectionState.Open) {
                    this.conexion.Close();
                }
            }

            return lista;
        }


        public bool AgregarJugador(Jugador param) {
            bool rta = true;

            try {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@usuario", param.Usuario);
                this.comando.Parameters.AddWithValue("@nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", param.Apellido);
                this.comando.Parameters.AddWithValue("@partidasGanadas", param.PartidasGanadas);
                this.comando.Parameters.AddWithValue("@puntajeEnTotal", param.PuntajeEnTotal);

                string sql = "INSERT INTO Jugadores ";
                sql += "(usuario, nombre, apellido, partidasGanadas, puntajeEnTotal) ";
                sql += "VALUES (@usuario, @nombre, @apellido, @partidasGanadas, @puntajeEnTotal);";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0) {
                    rta = false;
                }
            }
            catch (Exception) {
                rta = false;
                throw;
            }
            finally {
                if (this.conexion.State == ConnectionState.Open) {
                    this.conexion.Close();
                }
            }

            return rta;
        }
    }
}
