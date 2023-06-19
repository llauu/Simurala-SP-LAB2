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
        }

        private void btn_Aceptar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
