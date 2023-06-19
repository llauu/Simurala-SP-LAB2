using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Dado {
        private bool dadoSeleccionado;
        private int ultimoValor;

        public Dado() {
            this.dadoSeleccionado = false;
            this.ultimoValor = 0;
        }

        public bool DadoSeleccionado { get => dadoSeleccionado; set => dadoSeleccionado = value; }
        public int UltimoValor { get => ultimoValor; set => ultimoValor = value; }

        /// <summary>
        /// Genera un numero aleatorio entre 1 y 6
        /// </summary>
        /// <returns>Numero aleatorio entre 1 y 6</returns>
        public void TirarDado() {
            Random random = new Random(); 
            this.ultimoValor = random.Next(1, 7);
        }
    }
}
