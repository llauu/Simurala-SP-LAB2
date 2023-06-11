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
    public partial class FrmMenuPrincipal : Form {
        Usuario? usuarioActivo;
        FrmLogin? formLogin;

        public FrmMenuPrincipal() {
            InitializeComponent();
        }

        public FrmMenuPrincipal(Usuario usuarioActivo, FrmLogin formLogin) : this() {
            this.usuarioActivo = usuarioActivo;
            this.formLogin = formLogin;

            this.toolTip1.SetToolTip(this.btn_agregarJugador, "Crear nuevo jugador");
            this.toolTip1.SetToolTip(this.btn_crearJuego, "Crear nuevo juego");
            this.toolTip1.SetToolTip(this.btn_iniciarJuego, "Iniciar juego");
        }

        private void btn_agregarJugador_Click(object sender, EventArgs e) {
            FrmCrearJugador frmCrearJugador = new FrmCrearJugador();

            if (frmCrearJugador.ShowDialog() == DialogResult.OK) {
                //this.ActualizarListaJugadores();
                MessageBox.Show("Jugador creado con exito!", "Jugador creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            if(this.formLogin != null) {
                this.formLogin.Close();
            }
        }
    }
}
