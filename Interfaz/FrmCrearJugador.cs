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
            string usuario = this.txt_usuario.Text;
            string nombre = this.txt_nombre.Text;
            string apellido = this.txt_apellido.Text;

            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(usuario)) {
                try {
                    if (Sistema.CrearJugador(usuario, nombre, apellido)) {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex) {
                    FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
                }
            }
            else {
                FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, "Debe completar todos los campos para crear un jugador.");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
