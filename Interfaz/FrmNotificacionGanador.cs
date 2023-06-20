using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class FrmNotificacionGanador : Form {
        Partida? partidaFinalizada;

        public FrmNotificacionGanador() {
            InitializeComponent();
        }

        public FrmNotificacionGanador(Partida partidaFinalizada) : this() {
            this.partidaFinalizada = partidaFinalizada;

            BindingSource fuenteJugadorUno = new BindingSource();
            BindingSource fuenteJugadorDos = new BindingSource();

            fuenteJugadorUno.DataSource = new BindingSource(partidaFinalizada.JugadasJugadorUno, null);
            fuenteJugadorDos.DataSource = new BindingSource(partidaFinalizada.JugadasJugadorDos, null);

            dgv_JugadasJ1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadasJ2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.lbl_NPartida.Text = $"Partida N°{partidaFinalizada.Id}";
            this.lbl_Felicitaciones.Text = $"Felicitaciones, {partidaFinalizada.UsuarioGanador}!";
            this.lbl_Jugador1.Text = partidaFinalizada.JugadorUno?.Usuario;
            this.lbl_Jugador2.Text = partidaFinalizada.JugadorDos?.Usuario;
            this.dgv_JugadasJ1.DataSource = fuenteJugadorUno;
            this.dgv_JugadasJ2.DataSource = fuenteJugadorDos;

            dgv_JugadasJ1.Columns["Key"].HeaderText = "Jugada";
            dgv_JugadasJ1.Columns["Value"].HeaderText = "Puntaje";
            dgv_JugadasJ2.Columns["Key"].HeaderText = "Jugada";
            dgv_JugadasJ2.Columns["Value"].HeaderText = "Puntaje";
        }

        private void btn_Continuar_Click(object sender, EventArgs e) {
            Sistema.ListaPartidas.Add(this.partidaFinalizada!);
            this.Close();
        }
    }
}
