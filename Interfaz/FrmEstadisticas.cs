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
    public partial class FrmEstadisticas : Form {
        public FrmEstadisticas() {
            InitializeComponent();

            this.toolTip1.SetToolTip(this.btn_DescargarHistorial, "Descargar registro de la partida");
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e) {
            if (Sistema.ListaJugadores.Count > 0) {
                BindingSource fuenteVictorias = new BindingSource();
                BindingSource fuentePuntos = new BindingSource();

                fuenteVictorias.DataSource = new BindingSource(Sistema.ObtenerJugadoresConSusVictorias(), null);
                fuentePuntos.DataSource = new BindingSource(Sistema.ObtenerJugadoresConSusPuntosEnTotal(), null);

                this.dgv_JugadoresConVictorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dgv_JugadoresConPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dgv_JugadoresConVictorias.DataSource = fuenteVictorias;
                this.dgv_JugadoresConPuntos.DataSource = fuentePuntos;

                dgv_JugadoresConVictorias.Columns["Key"].HeaderText = "Jugador";
                dgv_JugadoresConVictorias.Columns["Value"].HeaderText = "Victorias";
                dgv_JugadoresConPuntos.Columns["Key"].HeaderText = "Jugador";
                dgv_JugadoresConPuntos.Columns["Value"].HeaderText = "Puntaje";
            }

            if (Sistema.ListaPartidas.Count > 0) {
                dgv_HistorialPartidas.DataSource = null;
                dgv_HistorialPartidas.DataSource = Sistema.ListaPartidas;

                dgv_HistorialPartidas.Columns["Id"].HeaderText = "ID";
                dgv_HistorialPartidas.Columns["JugadorUno"].HeaderText = "Jugador 1";
                dgv_HistorialPartidas.Columns["JugadorDos"].HeaderText = "Jugador 2";
                dgv_HistorialPartidas.Columns["JugadasJugadorUno"].Visible = false;
                dgv_HistorialPartidas.Columns["JugadasJugadorDos"].Visible = false;
                dgv_HistorialPartidas.Columns["PartidaIniciada"].Visible = false;
                dgv_HistorialPartidas.Columns["RegistroDeJuego"].Visible = false;
                dgv_HistorialPartidas.Columns["CancellationSource"].Visible = false;
                dgv_HistorialPartidas.Columns["Cancellation"].Visible = false;

                dgv_HistorialPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_HistorialPartidas.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_DescargarHistorial_Click(object sender, EventArgs e) {
            if (dgv_HistorialPartidas.Rows.Count > 0) {
                Partida partidaSeleccionada = (Partida)dgv_HistorialPartidas.CurrentRow.DataBoundItem;

                if (partidaSeleccionada is not null) {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();

                    saveFileDialog.DefaultExt = ".log";
                    saveFileDialog.FileName = $"registro_partida_{partidaSeleccionada.Id}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                        if (Archivos<Partida>.DescargarRegristroPartida(partidaSeleccionada, saveFileDialog.FileName)) {
                            MessageBox.Show($"Archivo descargado con exito!\n\nGuardado en: \n{saveFileDialog.FileName}", "Archivo descargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
