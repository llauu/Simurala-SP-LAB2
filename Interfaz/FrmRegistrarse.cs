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
    public partial class FrmRegistrarse : Form {
        public FrmRegistrarse() {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e) {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string correo = this.txtCorreo.Text;
            string clave = this.txtClave.Text;

            if (!(String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(apellido) && String.IsNullOrEmpty(correo) && String.IsNullOrEmpty(clave))) {
                try {
                    if(Sistema.RegistrarUsuario(nombre, apellido, correo, clave)) {
                        MessageBox.Show("Usuario registrado con exito!", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex) {
                    FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
                }
            }
            else {
                FrmLogin.ActualizarMensajeDeError(this.imgError, this.lblError, "Debe completar todos los campos para registrarse.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
