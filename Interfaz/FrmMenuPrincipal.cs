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
        BindingSource fuenteJugadorUno;
        BindingSource fuenteJugadorDos;
        PictureBox[] imagenesDados;
        Usuario? usuarioActivo;
        FrmLogin? formLogin;

        Partida partida = new Partida(new Jugador("pepe", "gomez", "pepe777"), new Jugador("maria", "parla", "xXmariaXx"));

        public FrmMenuPrincipal() {
            InitializeComponent();

            fuenteJugadorUno = new BindingSource();
            fuenteJugadorDos = new BindingSource();

            imagenesDados = new PictureBox[] {
                this.dado_uno,
                this.dado_dos,
                this.dado_tres,
                this.dado_cuatro,
                this.dado_cinco
            };
        }

        public FrmMenuPrincipal(Usuario usuarioActivo, FrmLogin formLogin) : this() {
            this.usuarioActivo = usuarioActivo;
            this.formLogin = formLogin;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e) {
            this.toolTip1.SetToolTip(this.btn_agregarJugador, "Crear nuevo jugador");
            this.toolTip1.SetToolTip(this.btn_crearJuego, "Crear nueva partida");
            this.toolTip1.SetToolTip(this.btn_frenarJuego, "Frenar juego");
            this.toolTip1.SetToolTip(this.btn_iniciarJuego, "Iniciar juego");

            fuenteJugadorUno.DataSource = new BindingSource(partida.JugadasJugadorUno, null);
            fuenteJugadorDos.DataSource = new BindingSource(partida.JugadasJugadorUno, null);

            dgv_JugadasJ1.DataSource = fuenteJugadorUno;
            dgv_JugadasJ2.DataSource = fuenteJugadorDos;

            dgv_JugadasJ1.Columns["Key"].HeaderText = "Jugada";
            dgv_JugadasJ1.Columns["Value"].HeaderText = "Puntaje";
            dgv_JugadasJ2.Columns["Key"].HeaderText = "Jugada";
            dgv_JugadasJ2.Columns["Value"].HeaderText = "Puntaje";

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
            partida.TirarDados();

            for (int i = 0; i < partida.Dados.Length; i++) {
                ActualizarImagenDado(partida.Dados[i].UltimoValor, imagenesDados[i]);
            }
        }

        private void btn_crearJuego_Click(object sender, EventArgs e) {
            FrmCrearPartida frmCrearSala = new FrmCrearPartida();

            if (frmCrearSala.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Partida creada con exito!", "Partida creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaPartidas();
            }
        }

        private void ActualizarListaPartidas() {
            dgv_Partidas.DataSource = null;
            dgv_Partidas.DataSource = Sistema.ListaPartidas;

            dgv_Partidas.Columns["JugadorUno"].HeaderText = "Jugador 1";
            dgv_Partidas.Columns["JugadorDos"].HeaderText = "Jugador 2";
            dgv_Partidas.Columns["JugadasJugadorUno"].Visible = false;
            dgv_Partidas.Columns["JugadasJugadorDos"].Visible = false;
        }
    }
}
