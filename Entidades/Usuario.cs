using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Usuario : IPersona {
        private static int ultimoId;

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

        static Usuario() {
            ultimoId = 0;
        }

        public Usuario(string nombre, string apellido, string correo, string clave) {
            this.id = ultimoId++;
            this.nombre = Validador.ValidarCadena(nombre);
            this.apellido = Validador.ValidarCadena(apellido);
            this.correo = Validador.ValidarCorreo(correo);
            this.clave = Validador.ValidarClaveValida(clave);
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
