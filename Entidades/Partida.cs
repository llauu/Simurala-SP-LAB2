using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Partida {
        private CancellationTokenSource cancellationSource;
        private CancellationToken cancellation;
        private Dictionary<string, int> jugadasJugadorUno;
        private Dictionary<string, int> jugadasJugadorDos;
        public event Action<Partida>? NotificadorGanador;
        public Action<Dado[]>? DelegadoMostrarDados;
        public Action? DelegadoCambioRegistro;
        private string registroDeJuego;
        private bool partidaIniciada;
        private Jugador? jugadorUno;
        private Jugador? jugadorDos;
        private Jugador? ganador;
        private Dado[] dados;
        private int id;

        private Partida() {
            this.cancellationSource = new CancellationTokenSource();
            this.cancellation = this.cancellationSource.Token;                                                       

            this.jugadasJugadorUno = new Dictionary<string, int>();
            this.jugadasJugadorDos = new Dictionary<string, int>();
            this.partidaIniciada = false;
            this.registroDeJuego = String.Empty;
            this.dados = new Dado[5];
            this.ganador = null;

            this.id = GenerarIdPartida();

            InicializarDados();
            InicializarJugadas();
        }

        public Partida(Jugador jugadorUno, Jugador jugadorDos, Action<Dado[]> delegadoMostrarDados, Action DelegadoCambioRegistro) : this() {
            this.DelegadoCambioRegistro = DelegadoCambioRegistro;
            this.DelegadoMostrarDados = delegadoMostrarDados;
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
        }

        public int Id { get => id; }
        public Dictionary<string, int> JugadasJugadorUno { get => jugadasJugadorUno; }
        public Dictionary<string, int> JugadasJugadorDos { get => jugadasJugadorDos; }
        public Jugador? JugadorUno { get => jugadorUno; }
        public Jugador? JugadorDos { get => jugadorDos; }
        public Dado[] Dados { get => dados; }
        public string RegistroDeJuego { get => registroDeJuego; }
        public bool PartidaIniciada { get => partidaIniciada; }
        public Jugador? Ganador { get => ganador; }
        public CancellationTokenSource CancellationSource { get => cancellationSource; }
        public CancellationToken Cancellation { get => cancellation; }

        private void InicializarDados() {
            for (int i = 0; i < dados.Length; i++) {
                dados[i] = new Dado();
            }
        }

        private void InicializarJugadas() {
            jugadasJugadorUno.Add("1", -1);
            jugadasJugadorUno.Add("2", -1);
            jugadasJugadorUno.Add("3", -1);
            jugadasJugadorUno.Add("4", -1);
            jugadasJugadorUno.Add("5", -1);
            jugadasJugadorUno.Add("6", -1);
            jugadasJugadorUno.Add("Escalera", -1);
            jugadasJugadorUno.Add("Full", -1);
            jugadasJugadorUno.Add("Poker", -1);
            jugadasJugadorUno.Add("Generala", -1);

            jugadasJugadorDos.Add("1", -1);
            jugadasJugadorDos.Add("2", -1);
            jugadasJugadorDos.Add("3", -1);
            jugadasJugadorDos.Add("4", -1);
            jugadasJugadorDos.Add("5", -1);
            jugadasJugadorDos.Add("6", -1);
            jugadasJugadorDos.Add("Escalera", -1);
            jugadasJugadorDos.Add("Full", -1);
            jugadasJugadorDos.Add("Poker", -1);
            jugadasJugadorDos.Add("Generala", -1);
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

        private int CalcularPuntaje(Dictionary<string, int> jugadasJugador) {
            int puntaje = 0;

            foreach (KeyValuePair<string, int> jugada in jugadasJugador) {
                puntaje += jugada.Value;
            }

            return puntaje;
        }

        public void ComenzarPartida() {
            int turnosMaximos = 8;
            int turnosJugados = 0;
            int puntajeJugadorUno;
            int puntajeJugadorDos;

            this.partidaIniciada = true;

            while (turnosJugados < turnosMaximos) {
                if(!cancellation.IsCancellationRequested) {
                    registroDeJuego += $"Turno {turnosJugados + 1}:\n";
                    JugarTurno(jugadorUno!);
                    turnosJugados++;

                    registroDeJuego += $"\n------------------------------------------------------------------\n";
                    DelegadoCambioRegistro?.Invoke();

                    registroDeJuego += $"Turno {turnosJugados + 1}:\n";
                    JugarTurno(jugadorDos!);
                    turnosJugados++;

                    registroDeJuego += $"\n------------------------------------------------------------------\n";
                    DelegadoCambioRegistro?.Invoke();
                }
                else {
                    registroDeJuego += $"\nPARTIDA CANCELADA\n";
                    DelegadoCambioRegistro?.Invoke();
                    dados[0].UltimoValor = 0;
                    break;
                }
            }
            
            puntajeJugadorUno = CalcularPuntaje(jugadasJugadorUno);
            puntajeJugadorDos = CalcularPuntaje(jugadasJugadorDos);

            if (puntajeJugadorUno > puntajeJugadorDos) {
                jugadorUno!.PartidasGanadas += 1;
                registroDeJuego += $"{jugadorUno.Usuario} GANO el juego!\n";
                this.ganador = jugadorUno;
                NotificadorGanador?.Invoke(this);
            }
            else if (puntajeJugadorUno < puntajeJugadorDos) {
                jugadorDos!.PartidasGanadas += 1;
                registroDeJuego += $"{jugadorDos.Usuario} GANO el juego!\n";
                this.ganador = jugadorDos;
                NotificadorGanador?.Invoke(this);
            }
            else {
                registroDeJuego += $"El juego termino en EMPATE!\n";
            }

            DelegadoCambioRegistro?.Invoke();

            jugadorUno!.PuntajeEnTotal += puntajeJugadorUno;
            jugadorDos!.PuntajeEnTotal += puntajeJugadorDos;

            dados[0].UltimoValor = 0;
        }

        private void TirarDados() {
            foreach(Dado dado in dados) {
                if (dado.DadoSeleccionado == false) {
                    dado.TirarDado();
                }
            }
        }

        private void JugarTurno(Jugador jugador) {
            int numeroTirada = 0;
            bool repetirTirada;
            bool esUltimoTiro = false;

            DeseleccionarDados();

            do {
                repetirTirada = false;
                this.TirarDados();
                DelegadoMostrarDados?.Invoke(dados);
                numeroTirada++;

                registroDeJuego += $"\n{jugador.Usuario} tiro los dados y saco: {dados[0].UltimoValor}, {dados[1].UltimoValor}, {dados[2].UltimoValor}, {dados[3].UltimoValor} y {dados[4].UltimoValor}\n";
                DelegadoCambioRegistro?.Invoke();

                if(numeroTirada == 3) {
                    esUltimoTiro = true;
                }

                if (jugador == jugadorUno!) {
                    if (!VerificarSiTieneJugadaImportante(dados, jugadasJugadorUno)) {
                        if (!VerificarSiTieneJugadaComun(dados, jugadasJugadorUno, esUltimoTiro)) {
                            repetirTirada = true;

                            if (esUltimoTiro) {
                                TacharUnaJugada(JugadasJugadorUno);
                            }
                            else {
                                if (!SeleccionarDadosConPosibleJugada(dados)) {
                                    SeleccionarDadosRandom(dados);
                                }
                            }
                        }
                    }
                }
                else {
                    if (!VerificarSiTieneJugadaImportante(dados, jugadasJugadorDos)) { // Si no tiene jugada importante
                        if (!VerificarSiTieneJugadaComun(dados, jugadasJugadorDos, esUltimoTiro)) { // Si no tiene jugada normal
                            repetirTirada = true; // Repite tirada

                            if (esUltimoTiro) {
                                TacharUnaJugada(JugadasJugadorDos);
                            }
                            else {
                                if (!SeleccionarDadosConPosibleJugada(dados)) { // Me fijo si tiene dados que se repiten para seleciconarlos
                                    SeleccionarDadosRandom(dados);// Selecciono 2 dados random que no voy a tirar en el proximo tiro
                                }
                            }
                        }
                    }
                }

                Thread.Sleep(2000);
            } while (numeroTirada < 3 && repetirTirada);
        }

        private bool SeleccionarDadosConPosibleJugada(Dado[] dados) {
            bool tieneDadosConPosibleJugada = false;
            int cantidadDadosSeleccionados = 0;
            int vecesRepetido;

            for (int i = 0; i < dados.Length; i++) {
                vecesRepetido = ContarVecesRepetidasUnNumero(dados, dados[i].UltimoValor);

                if (vecesRepetido >= 2) {
                    for (int j = 0; j < dados.Length; j++) {
                        if (dados[j].UltimoValor == dados[i].UltimoValor) {
                            dados[j].DadoSeleccionado = true;
                            cantidadDadosSeleccionados++;
                        }
                    }

                    registroDeJuego += $"Se guardo {cantidadDadosSeleccionados} dados con el valor {dados[i].UltimoValor}.\n";
                    tieneDadosConPosibleJugada = true;
                    break;
                }
            }

            return tieneDadosConPosibleJugada;
        }

        private void SeleccionarDadosRandom(Dado[] dados) {
            Random rand = new Random(); 
            int cantidadDadosSeleccionados = 0;
            
            while (cantidadDadosSeleccionados < 2) {
                int numeroRandom = rand.Next(0, 5);

                if (dados[numeroRandom].DadoSeleccionado == false) {
                    dados[numeroRandom].DadoSeleccionado = true;

                    registroDeJuego += $"Se guardo el dado con el valor {dados[numeroRandom].UltimoValor}.\n";

                    cantidadDadosSeleccionados++;
                }
            }
        }

        private bool TacharUnaJugada(Dictionary<string, int> jugadasJugador) {
            if (jugadasJugador["Generala"] == -1) {
                jugadasJugador["Generala"] = 0;
                registroDeJuego += $"No pudo hacer ningun juego y coloco 0 a la generala.\n";

                return true;
            }
            else if (jugadasJugador["Poker"] == -1) {
                jugadasJugador["Poker"] = 0;
                registroDeJuego += $"No pudo hacer ningun juego y coloco 0 al poker.\n";
                return true;
            }
            else if (jugadasJugador["Full"] == -1) {
                jugadasJugador["Full"] = 0;
                registroDeJuego += $"No pudo hacer ningun juego y coloco 0 al full.\n";
                return true;
            }
            else if (jugadasJugador["Escalera"] == -1) {
                jugadasJugador["Escalera"] = 0;
                registroDeJuego += $"No pudo hacer ningun juego y coloco 0 a la escalera.\n";
                return true;
            }
            else {
                for (int i = 1; i < dados.Length + 1; i++) {
                    if (jugadasJugador[i.ToString()] == -1) {
                        jugadasJugador[i.ToString()] = 0;
                        registroDeJuego += $"No pudo hacer ningun juego y coloco 0 al {i}.\n";
                        return true;
                    }
                }
            }

            DelegadoCambioRegistro?.Invoke();

            return false;
        }

        private bool VerificarSiTieneJugadaImportante(Dado[] dados, Dictionary<string, int> jugadasJugador) {
            if (VerificarGenerala(dados) && jugadasJugador["Generala"] == -1) {
                jugadasJugador["Generala"] = 60;
                registroDeJuego += $"Hizo generala y anoto 60 puntos.\n";
                return true;
            }
            else if (VerificarPoker(dados) && jugadasJugador["Poker"] == -1) {
                jugadasJugador["Poker"] = 40;
                registroDeJuego += $"Hizo poker y anoto 40 puntos.\n";
                return true;
            }
            else if (VerificarFull(dados) && jugadasJugador["Full"] == -1) {
                jugadasJugador["Full"] = 30;
                registroDeJuego += $"Hizo full y anoto 30 puntos.\n";
                return true;
            }
            else if (VerificarEscalera(dados) && jugadasJugador["Escalera"] == -1) {
                jugadasJugador["Escalera"] = 20;
                registroDeJuego += $"Hizo escalera y anoto 20 puntos.\n";
                return true;
            }

            DelegadoCambioRegistro?.Invoke();

            return false;
        }

        private bool VerificarSiTieneJugadaComun(Dado[] dados, Dictionary<string, int> jugadasJugador, bool esUltimoTiro) {
            bool tieneJugadaComun = false;
            int vecesRepetidasMax = 0;
            int numeroJugadaMax = 0;
            int vecesRepetidas;
            int puntajeMaximo;

            // 6 es la cantidad de jugadas comunes, osea del 1 al 6
            for (int i = 1; i <= 6; i++) {
                if(jugadasJugador[i.ToString()] == -1) { //CHEQUEO SI TODAVIA NO TIENE JUEGO EN ESE NUMERO
                    vecesRepetidas = ContarVecesRepetidasUnNumero(dados, i);

                    if ((i == 1 || vecesRepetidas > vecesRepetidasMax) && (vecesRepetidas > 2 || esUltimoTiro)) {
                        vecesRepetidasMax = vecesRepetidas;
                        numeroJugadaMax = i;

                        tieneJugadaComun = true;
                    }
                }
            }

            if(tieneJugadaComun) {
                puntajeMaximo = numeroJugadaMax * vecesRepetidasMax;
                jugadasJugador[numeroJugadaMax.ToString()] = puntajeMaximo;

                registroDeJuego += $"Anoto {puntajeMaximo} puntos al {numeroJugadaMax}.\n";
                DelegadoCambioRegistro?.Invoke();
            }

            return tieneJugadaComun;
        }

        private void DeseleccionarDados() {
            foreach(Dado dado in this.dados) {
                dado.DadoSeleccionado = false;
            }
        }

        private bool VerificarEscalera(Dado[] dados) {
            bool escaleraValida = false;

            dados.OrderBy(dado => dado.UltimoValor);

            if ((dados[0].UltimoValor == 1 && dados[1].UltimoValor == 2 && dados[2].UltimoValor == 3 && dados[3].UltimoValor == 4 && dados[4].UltimoValor == 5) ||
                (dados[0].UltimoValor == 2 && dados[1].UltimoValor == 3 && dados[2].UltimoValor == 4 && dados[3].UltimoValor == 5 && dados[4].UltimoValor == 6)){
                escaleraValida = true;
            }

            return escaleraValida;
        }

        private bool VerificarFull(Dado[] dados) {
            int cantidadDadosIguales;
            bool fullValido = false;
            bool tieneTresIguales = false;
            bool tieneDosIguales = false;

            for (int i = 0; i < dados.Length; i++) {
                cantidadDadosIguales = 0;

                for(int j = 0; j < dados.Length; j++) {
                    if (dados[i].UltimoValor == dados[j].UltimoValor) {
                        cantidadDadosIguales++;
                    }
                }

                if(cantidadDadosIguales == 2) {
                    tieneDosIguales = true;
                }

                if (cantidadDadosIguales == 3) {
                    tieneTresIguales = true;
                    break;
                }
            }

            if(tieneDosIguales && tieneTresIguales) {
                fullValido = true;
            }

            return fullValido;
        }

        private bool VerificarPoker(Dado[] dados) {
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

        private bool VerificarGenerala(Dado[] dados) {
            bool generalaValida = true;

            for(int i = 1; i < dados.Length; i++) {
                if (dados[0].UltimoValor != dados[i].UltimoValor) {
                    generalaValida = false;
                }
            }

            return generalaValida;
        }

        private int ContarVecesRepetidasUnNumero(Dado[] dados, int numero) {
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
