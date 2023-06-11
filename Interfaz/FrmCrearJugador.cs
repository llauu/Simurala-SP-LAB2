using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Interfaz {
    public partial class FrmCrearJugador : Form {
        public FrmCrearJugador() {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e) {
            string nombre = this.txt_nombre.Text;

            if (!String.IsNullOrEmpty(nombre)) {
                try {
                    if (Sistema.CrearJugador(nombre)) {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex) {
                    FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
                }
            }
            else {
                FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, "Debe colocar un nombre para crear un jugador.");
            }
        }
    }
}
