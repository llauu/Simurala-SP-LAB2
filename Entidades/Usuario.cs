using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Usuario : IPersona {
        private int id;
        private string nombre;
        private string apellido;
        private string correo;
        private string clave;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }

        public Usuario(int id, string nombre, string apellido, string correo, string clave) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.clave = clave;
        }

        public static int GenerarIdUsuario() {
            bool idUnico;
            int id;

            do {
                id = Sistema.GenerarIdNumerico();
                idUnico = Validador.ValidarIdUsuarioUnico(id);
            } while (!idUnico);

            return id;
        }

        public bool ChequearCorreo(string correo) {
            return correo == this.correo;
        }

        public bool ChequearClave(string clave) {
            return clave == this.clave;
        }

        public static bool operator ==(Usuario usuario1, Usuario usuario2) {
            bool rta = false;

            if (((object?)usuario1) == null && ((object?)usuario2) == null) {
                rta = true;
            }
            else {
                if (usuario1 is not null && usuario2 is not null && usuario1.id == usuario2.id && usuario1.nombre == usuario2.nombre && usuario1.apellido == usuario2.apellido) {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Usuario usuario1, Usuario usuario2) {
            return !(usuario1 == usuario2);
        }
        
        public override bool Equals(object? obj) {
            Usuario? usuario = obj as Usuario;
            return usuario is not null && this == usuario;
        }

        public override int GetHashCode() {
            return this.id;
        }

        public override string ToString() {
            return $"{this.nombre} {this.apellido}";
        }
    }
}
