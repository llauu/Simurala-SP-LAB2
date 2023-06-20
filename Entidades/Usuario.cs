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

        public override string ToString() {
            return $"{this.nombre}";
        }
    }
}
