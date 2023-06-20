using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Jugador : IPersona {
        private string? usuario;
        private string? nombre;
        private string? apellido;
        private bool partidaEnCurso;
        private int partidasGanadas;
        private int puntajeEnTotal;

        public string Usuario { get => usuario!; set => usuario = value; }
        public string Nombre { get => nombre!; set => nombre = value; }
        public string Apellido { get => apellido!; set => apellido = value; }
        public bool PartidaEnCurso { get => partidaEnCurso; set => partidaEnCurso = value; }
        public int PuntajeEnTotal { get => puntajeEnTotal; set => puntajeEnTotal = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }

        public Jugador() {
            this.partidasGanadas = 0;
            this.puntajeEnTotal = 0;
            this.partidaEnCurso = false;
        }

        public Jugador(string usuario, string nombre, string apellido) : this() {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Jugador(string usuario, string nombre, string apellido, int partidasGanadas, int puntajeEnTotal) : this(usuario, nombre, apellido){
            this.partidasGanadas = partidasGanadas;
            this.puntajeEnTotal = puntajeEnTotal;
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2) {
            bool rta = false;

            if(((object?)jugador1) == null && ((object?)jugador2) == null) {
                rta = true;
            }
            else {
                if(jugador1 is not null && jugador2 is not null && jugador1.usuario == jugador2.usuario && jugador1.nombre == jugador2.nombre && jugador1.apellido == jugador2.apellido) {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2) {
            return !(jugador1 == jugador2);
        }

        public override string ToString() {
            return $"{this.usuario}";
        }
    }
}
