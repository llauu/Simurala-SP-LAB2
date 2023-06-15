using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Partida {
        private Dictionary<string, int> jugadasJugadorUno;
        private Dictionary<string, int> jugadasJugadorDos;
        private Jugador? jugadorUno;
        private Jugador? jugadorDos;
        private Dado[] dados;
        private int id;

        private Partida() {
            jugadasJugadorUno = new Dictionary<string, int>();
            jugadasJugadorDos = new Dictionary<string, int>();
            dados = new Dado[5];

            id = GenerarIdPartida();

            InicializarDados();
            InicializarJugadas();
        }

        public Partida(Jugador jugadorUno, Jugador jugadorDos) : this() {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
        }

        public int Id { get => id; }
        public Dictionary<string, int> JugadasJugadorUno { get => jugadasJugadorUno; }
        public Dictionary<string, int> JugadasJugadorDos { get => jugadasJugadorDos; }
        public Jugador? JugadorUno { get => jugadorUno; }
        public Jugador? JugadorDos { get => jugadorDos; }
        public Dado[] Dados { get => dados; }

        private void InicializarDados() {
            for (int i = 0; i < dados.Length; i++) {
                dados[i] = new Dado();
            }
        }

        private void InicializarJugadas() {
            jugadasJugadorUno.Add("1", 0);
            jugadasJugadorUno.Add("2", 0);
            jugadasJugadorUno.Add("3", 0);
            jugadasJugadorUno.Add("4", 0);
            jugadasJugadorUno.Add("5", 0);
            jugadasJugadorUno.Add("6", 0);
            jugadasJugadorUno.Add("Escalera", 0);
            jugadasJugadorUno.Add("Full", 0);
            jugadasJugadorUno.Add("Poker", 0);
            jugadasJugadorUno.Add("Generala", 0);

            jugadasJugadorDos.Add("1", 0);
            jugadasJugadorDos.Add("2", 0);
            jugadasJugadorDos.Add("3", 0);
            jugadasJugadorDos.Add("4", 0);
            jugadasJugadorDos.Add("5", 0);
            jugadasJugadorDos.Add("6", 0);
            jugadasJugadorDos.Add("Escalera", 0);
            jugadasJugadorDos.Add("Full", 0);
            jugadasJugadorDos.Add("Poker", 0);
            jugadasJugadorDos.Add("Generala", 0);
        }

        private int GenerarIdPartida() {
            bool idUnico;
            int id;

            do {
                id = Sistema.GenerarIdNumerico();
                idUnico = Validador.ValidarIdPartidaUnico(id);
            } while (!idUnico);

            return id;
        }

        //private int CalcularPuntaje(Dictionary<string, int> jugadasJugador) {
        //    int puntaje = 0;

        //    foreach (KeyValuePair<string, int> jugada in jugadasJugador) {
        //        puntaje += jugada.Value;
        //    }

        //    return puntaje;
        //}

        public void TirarDados() {
            foreach(Dado dado in dados) {
                if (dado.DadoSeleccionado == false) {
                    dado.TirarDado();
                }
            }
        }

        public void JugarTurno(Jugador jugador) {
            int dadosSeleccionados = 0;
            int numeroTirada = 0;
            bool repetirTirada = false;

            DeseleccionarDados();

            while (numeroTirada < 3 && repetirTirada) {
                this.TirarDados();
                numeroTirada++;

                // Verificar si el jugador quiere volver a tirar los dados
                if (jugador == jugadorUno!) {
                    if(!VerificarSiTieneJugadaImportante(dados, jugadasJugadorUno)) {

                    }
                }
                else {
                    if (!VerificarSiTieneJugadaImportante(dados, jugadasJugadorDos)) {

                    }
                }
            }
        }

        public bool VerificarSiTieneJugadaImportante(Dado[] dados, Dictionary<string, int> jugadasJugador) {
            if (VerificarGenerala(dados) && jugadasJugador["Generala"] == 0) {
                jugadasJugador["Generala"] = 60;
                return true;
            }
            else if (VerificarPoker(dados) && jugadasJugador["Poker"] == 0) {
                jugadasJugador["Poker"] = 40;
                return true;
            }
            else if (VerificarFull(dados) && jugadasJugador["Full"] == 0) {
                jugadasJugador["Full"] = 30;
                return true;
            }
            else if (VerificarEscalera(dados) && jugadasJugador["Escalera"] == 0) {
                jugadasJugador["Escalera"] = 20;
                return true;
            }

            return false;
        }

        public bool VerificarSiTieneJugadaComun(Dado[] dados, Dictionary<string, int> jugadasJugador) {
            bool tieneJugadaComun = false;
            int vecesRepetidasMax = 0;
            int numeroJugadaMax = 0;
            int vecesRepetidas;
            int puntajeMaximo;

            for(int i = 1; i < dados.Length + 1; i++) {
                if(jugadasJugador[i.ToString()] == 0) { //CHEQUEO SI TODAVIA NO TIENE JUEGO EN ESE NUMERO
                    vecesRepetidas = ContarVecesRepetidasUnNumero(dados, i);

                    if (i == 1 || vecesRepetidas > vecesRepetidasMax) {
                        vecesRepetidasMax = vecesRepetidas;
                        numeroJugadaMax = i;

                        tieneJugadaComun = true;
                    }
                }
            }

            if(tieneJugadaComun) {
                puntajeMaximo = numeroJugadaMax * vecesRepetidasMax;
                jugadasJugador[numeroJugadaMax.ToString()] = puntajeMaximo;
            }

            return tieneJugadaComun;
        }

        public void DeseleccionarDados() {
            foreach(Dado dado in this.dados) {
                dado.DadoSeleccionado = false;
            }
        }


        public bool VerificarEscalera(Dado[] dados) {
            bool escaleraValida = false;

            dados.OrderBy(dado => dado.UltimoValor);

            if ((dados[0].UltimoValor == 1 && dados[1].UltimoValor == 2 && dados[2].UltimoValor == 3 && dados[3].UltimoValor == 4 && dados[4].UltimoValor == 5) ||
                (dados[0].UltimoValor == 2 && dados[1].UltimoValor == 3 && dados[2].UltimoValor == 4 && dados[3].UltimoValor == 5 && dados[4].UltimoValor == 6)){
                escaleraValida = true;
            }

            return escaleraValida;
        }

        public bool VerificarFull(Dado[] dados) {
            bool fullValido = false;
            int cantidadDadosIguales;

            for (int i = 0; i < dados.Length; i++) {
                cantidadDadosIguales = 0;

                for(int j = 0; j < dados.Length; j++) {
                    if (dados[i].UltimoValor == dados[j].UltimoValor) {
                        cantidadDadosIguales++;
                    }
                }

                if (cantidadDadosIguales == 3) {
                    for (int j = 0; j < dados.Length; j++) {
                        if (dados[i].UltimoValor != dados[j].UltimoValor) {
                            for (int k = 0; k < dados.Length; k++) {
                                if (dados[j].UltimoValor == dados[k].UltimoValor) {
                                    fullValido = true;
                                }
                            }
                        }
                    }
                }
            }

            return fullValido;
        }

        public bool VerificarPoker(Dado[] dados) {
            bool pokerValido = false;
            int cantidadDadosIguales;

            for (int i = 0; i < dados.Length; i++) {
                cantidadDadosIguales = 0;

                for(int j = 0; j < dados.Length; j++) {
                    if (dados[i].UltimoValor == dados[j].UltimoValor) {
                        cantidadDadosIguales++;
                    }
                }

                if (cantidadDadosIguales == 4) {
                    pokerValido = true;
                }
            }

            return pokerValido;
        }

        public bool VerificarGenerala(Dado[] dados) {
            bool generalaValida = false;

            for(int i = 1; i < dados.Length; i++) {
                if (dados[0].UltimoValor == dados[i].UltimoValor) {
                    generalaValida = true;
                }
            }

            return generalaValida;
        }

        public int ContarVecesRepetidasUnNumero(Dado[] dados, int numero) {
            int contador = 0;   

            for(int i = 0; i < dados.Length; i++) {
                if (dados[i].UltimoValor == numero) {
                    contador++;
                }
            }

            return contador;
        }


    }
}
