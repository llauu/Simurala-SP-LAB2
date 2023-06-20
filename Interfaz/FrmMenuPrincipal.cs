using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class FrmMenuPrincipal : Form {
        private List<Partida> partidasActivas;
        private PictureBox[] imagenesDados;
        private Task? inicioPartida;
        private FrmLogin? formLogin;

        // BORRAR
        //Partida partida;
        //Partida partidaDos;

        public FrmMenuPrincipal() {
            InitializeComponent();

            this.partidasActivas = new List<Partida>();

            // BORRAR --------------------------------------------------------
            //partida = new Partida(new Jugador("pepe", "gomez", "pepe777"), new Jugador("maria", "parla", "xXmariaXx"), ActualizarDados, SeleccionarPartida);
            //partidaDos = new Partida(new Jugador("juan", "gomaaez", "juani76"), new Jugador("maria", "parla", "kikiGamer"), ActualizarDados, SeleccionarPartida);
            //partida.NotificadorGanador += InformarGanador;
            //partidaDos.NotificadorGanador += InformarGanador;
            //partidasActivas.Add(partida);
            //partidasActivas.Add(partidaDos);
            // ---------------------------------------------------------------

            this.imagenesDados = new PictureBox[] {
                this.dado_uno,
                this.dado_dos,
                this.dado_tres,
                this.dado_cuatro,
                this.dado_cinco
            };
        }

        public FrmMenuPrincipal(FrmLogin formLogin) : this() {
            this.formLogin = formLogin;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e) {
            this.toolTip1.SetToolTip(this.btn_agregarJugador, "Crear nuevo jugador");
            this.toolTip1.SetToolTip(this.btn_crearJuego, "Crear nueva partida");
            this.toolTip1.SetToolTip(this.btn_frenarJuego, "Frenar juego");
            this.toolTip1.SetToolTip(this.btn_iniciarJuego, "Iniciar juego");
            this.toolTip1.SetToolTip(this.btn_Estadisticas, "Estadisticas historicas");

            ActualizarListaPartidas();
        }

        private void btn_agregarJugador_Click(object sender, EventArgs e) {
            FrmCrearJugador frmCrearJugador = new FrmCrearJugador();

            if (frmCrearJugador.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Jugador creado con exito!", "Jugador creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.formLogin != null) {
                this.formLogin.Close();
            }
        }

        public void ActualizarDados(Dado[] dados) {
            if (this.InvokeRequired) {
                object[] parametros = { dados };

                this.Invoke(ActualizarDados, parametros);
            }
            else {
                if (dados[0].UltimoValor == 0) {
                    dado_uno.Visible = false;
                    dado_dos.Visible = false;
                    dado_tres.Visible = false;
                    dado_cuatro.Visible = false;
                    dado_cinco.Visible = false;
                }
                else {
                    for (int i = 0; i < dados.Length; i++) {
                        ActualizarImagenDado(dados[i].UltimoValor, imagenesDados[i]);
                    }
                }
            }
        }

        private void ActualizarImagenDado(int valorDelDado, PictureBox imagenAActualizar) {
            switch (valorDelDado) {
                case 1:
                    imagenAActualizar.Image = Image.FromFile(Sistema.RutaImagenDadoUno);
                    break;
                case 2:
                    imagenAActualizar.Image = Image.FromFile(Sistema.RutaImagenDadoDos);
                    break;
                case 3:
                    imagenAActualizar.Image = Image.FromFile(Sistema.RutaImagenDadoTres);
                    break;
                case 4:
                    imagenAActualizar.Image = Image.FromFile(Sistema.RutaImagenDadoCuatro);
                    break;
                case 5:
                    imagenAActualizar.Image = Image.FromFile(Sistema.RutaImagenDadoCinco);
                    break;
                case 6:
                    imagenAActualizar.Image = Image.FromFile(Sistema.RutaImagenDadoSeis);
                    break;
            }

            imagenAActualizar.Visible = true;
        }

        private void btn_iniciarJuego_Click(object sender, EventArgs e) {
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            if (partidasActivas.Count > 0) {
                Partida partida = (Partida)dgv_Partidas.CurrentRow.DataBoundItem;

                if (!partida.PartidaIniciada) {
                    inicioPartida = new Task(partida.JugarPartida);
                    inicioPartida.Start();
                }
                else {
                    FrmLogin.ActualizarMensajeDeError(imgError, lblError, "Esta partida ya ha sido iniciada.");
                }
            }
            else {
                FrmLogin.ActualizarMensajeDeError(imgError, lblError, "No hay partidas creadas para iniciar.");
            }
        }

        private void SeleccionarPartida() {
            if (partidasActivas.Count > 0) {
                Partida partidaSeleccionada = (Partida)dgv_Partidas.CurrentRow.DataBoundItem;
                ActualizarDatosPartida(partidaSeleccionada);
            }
        }

        private void btn_crearJuego_Click(object sender, EventArgs e) {
            FrmCrearPartida frmCrearPartida = new FrmCrearPartida(ActualizarDados, SeleccionarPartida, InformarGanador);

            if (frmCrearPartida.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Partida creada con exito!", "Partida creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                partidasActivas.Add(frmCrearPartida.PartidaCreada);
                ActualizarListaPartidas();
            }
        }

        private void ActualizarListaPartidas() {
            if (partidasActivas.Count > 0) {
                dgv_Partidas.DataSource = null;
                dgv_Partidas.DataSource = partidasActivas;

                dgv_Partidas.Columns["Id"].HeaderText = "ID";
                dgv_Partidas.Columns["JugadorUno"].HeaderText = "Jugador 1";
                dgv_Partidas.Columns["JugadorDos"].HeaderText = "Jugador 2";
                dgv_Partidas.Columns["JugadasJugadorUno"].Visible = false;
                dgv_Partidas.Columns["JugadasJugadorDos"].Visible = false;
                dgv_Partidas.Columns["PartidaIniciada"].Visible = false;
                dgv_Partidas.Columns["RegistroDeJuego"].Visible = false;
                dgv_Partidas.Columns["CancellationSource"].Visible = false;
                dgv_Partidas.Columns["Cancellation"].Visible = false;

                dgv_Partidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Partidas.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void ActualizarDatosPartida(Partida partidaSeleccionada) {
            if (partidaSeleccionada != null) {
                BindingSource fuenteJugadorUno = new BindingSource();
                BindingSource fuenteJugadorDos = new BindingSource();

                if (this.InvokeRequired) {
                    object[] parametros = { partidaSeleccionada };
                    this.Invoke(ActualizarDatosPartida, parametros);
                }
                else {
                    ActualizarDados(partidaSeleccionada.Dados);

                    fuenteJugadorUno.DataSource = new BindingSource(partidaSeleccionada.JugadasJugadorUno, null);
                    fuenteJugadorDos.DataSource = new BindingSource(partidaSeleccionada.JugadasJugadorDos, null);

                    dgv_JugadasJ1.DataSource = fuenteJugadorUno;
                    dgv_JugadasJ2.DataSource = fuenteJugadorDos;

                    dgv_JugadasJ1.CurrentCell = null;
                    dgv_JugadasJ2.CurrentCell = null;

                    this.rtb_Jugadas.Text = partidaSeleccionada.RegistroDeJuego;
                    this.rtb_Jugadas.SelectionStart = this.rtb_Jugadas.Text.Length;
                    this.rtb_Jugadas.ScrollToCaret();

                    this.lbl_Jugador1.Text = partidaSeleccionada.JugadorUno?.Usuario;
                    this.lbl_Jugador2.Text = partidaSeleccionada.JugadorDos?.Usuario;

                    dgv_JugadasJ1.Columns["Key"].HeaderText = "Jugada";
                    dgv_JugadasJ1.Columns["Value"].HeaderText = "Puntaje";
                    dgv_JugadasJ2.Columns["Key"].HeaderText = "Jugada";
                    dgv_JugadasJ2.Columns["Value"].HeaderText = "Puntaje";
                }
            }
        }

        private void dgv_JugadasJ1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            // Obtener la fila actual del evento
            DataGridViewRow row = dgv_JugadasJ1.Rows[e.RowIndex];

            // Obtener el valor de la celda que determinará el color de fondo
            int valor = Convert.ToInt32(row.Cells["Value"].Value);

            if (valor == -1) {
                row.DefaultCellStyle.BackColor = Color.IndianRed;
            }
            else {
                row.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }

        private void dgv_JugadasJ2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            // Obtener la fila actual del evento
            DataGridViewRow row = dgv_JugadasJ2.Rows[e.RowIndex];

            // Obtener el valor de la celda que determinará el color de fondo
            int valor = Convert.ToInt32(row.Cells["Value"].Value);

            if (valor == -1) {
                row.DefaultCellStyle.BackColor = Color.IndianRed;
            }
            else {
                row.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }

        private void btn_frenarJuego_Click(object sender, EventArgs e) {
            if (partidasActivas.Count > 0) {
                Partida partida = (Partida)dgv_Partidas.CurrentRow.DataBoundItem;

                if (partida.PartidaIniciada) {
                    partida.CancellationSource.Cancel();
                }
                else {
                    FrmLogin.ActualizarMensajeDeError(imgError, lblError, "La partida aun no fue iniciada.");
                }
            }
            else {
                FrmLogin.ActualizarMensajeDeError(imgError, lblError, "No hay partidas creadas para frenar.");
            }
        }

        private void dgv_Partidas_CellClick(object sender, DataGridViewCellEventArgs e) {
            SeleccionarPartida();
        }

        private void InformarGanador(Partida partidaFinalizada) {
            FrmNotificacionGanador frmNotificacionGanador = new FrmNotificacionGanador(partidaFinalizada);
            frmNotificacionGanador.ShowDialog();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e) {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog();
        }
    }
}
