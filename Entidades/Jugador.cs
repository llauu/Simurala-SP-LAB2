using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Jugador : IPersona{
        private string? nombre;
        private string? apellido;
        private string? usuario;
        private bool partidaEnCurso;
        private int partidasGanadas;
        private int puntajeEnTotal;

        public string Nombre { get => nombre!; set => nombre = value; }
        public string Apellido { get => apellido!; set => apellido = value; }
        public string Usuario { get => usuario!; set => usuario = value; }
        public bool PartidaEnCurso { get => partidaEnCurso; set => partidaEnCurso = value; }
        public int PuntajeEnTotal { get => puntajeEnTotal; set => puntajeEnTotal = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }

        private Jugador() {
            this.partidasGanadas = 0;
            this.puntajeEnTotal = 0;
            this.partidaEnCurso = false;
        }

        public Jugador(string nombre, string apellido, string usuario) : this() {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2) {
            return jugador1.usuario == jugador2.usuario;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2) {
            return !(jugador1 == jugador2);
        }

        public override bool Equals(object? obj) {
            Jugador? jugador = obj as Jugador;

            return jugador is not null && this == jugador;
        }

        public override int GetHashCode() {
            return this.usuario!.GetHashCode();
        }

        public override string ToString() {
            return $"{this.usuario}";
        }
    }
}
