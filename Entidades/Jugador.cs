using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Jugador {
        private string nombre;
        private int puntaje;

        private Jugador() {
            this.puntaje = 0;
        }

        public Jugador(string nombre) : this() {
            this.nombre = nombre;
        }

        public string Nombre {
            get {
                return this.nombre;
            }
        }

        public int Puntaje {
            get {
                return this.puntaje;
            }
        }
    }
}
