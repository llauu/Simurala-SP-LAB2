using Entidades;

namespace Interfaz {
    public partial class FrmCrearPartida : Form {
        private Partida? partidaCreada;
        private Action DelegadoCambioRegistro;
        private Action<Dado[]> ActualizarDados;

        public Partida PartidaCreada { get => partidaCreada!; }

        public FrmCrearPartida(Action<Dado[]> ActualizarDados, Action DelegadoCambioRegistro) {
            InitializeComponent();

            this.DelegadoCambioRegistro = DelegadoCambioRegistro;
            this.ActualizarDados = ActualizarDados;
            this.partidaCreada = null;
        }

        private void FrmCrearSala_Load(object sender, EventArgs e) {
            foreach (Jugador jugador in Sistema.ListaJugadores) {
                cb_Jugador1.Items.Add(jugador);
                cb_Jugador2.Items.Add(jugador);
            }
        }

        private void btn_Crear_Click(object sender, EventArgs e) {
            Jugador jugador1Seleccionado = (Jugador)cb_Jugador1.SelectedItem;
            Jugador jugador2Seleccionado = (Jugador)cb_Jugador2.SelectedItem;

            if (jugador1Seleccionado is not null && jugador2Seleccionado is not null) {
                try {
                    partidaCreada = Sistema.CrearPartida(jugador1Seleccionado, jugador2Seleccionado, ActualizarDados, DelegadoCambioRegistro);

                    if (partidaCreada is not null) {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex) {
                    FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
                }
            }
            else {
                FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, "Debe seleccionar dos jugadores para crear una sala.");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
