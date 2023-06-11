using Entidades;

namespace Interfaz {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {
            try {
                // CARGAR USUARIOS
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al cargar el archivo json de usuarios. Se cerrara la aplicacion. \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            IntentarInicioSesion();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e) {
            FrmRegistrarse frmRegistrarse = new FrmRegistrarse();
            frmRegistrarse.ShowDialog();
        }

        private void txtClaveOCorreo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                IntentarInicioSesion();
            }
        }

        private void IntentarInicioSesion() {
            string correoIngresado = this.txtCorreo.Text;
            string claveIngresada = this.txtClave.Text;
            int indiceUsuarioIngresado;

            if (correoIngresado == String.Empty || claveIngresada == String.Empty) {
                ActualizarMensajeDeError(this.imgError, this.lblError, "Debes ingresar un correo y/o contrase�a.");
            }
            else {
                indiceUsuarioIngresado = Sistema.IniciarSesion(correoIngresado, claveIngresada);

                if (indiceUsuarioIngresado >= 0) {
                    AccederMenuPrincipal(indiceUsuarioIngresado);
                }
                else {
                    ActualizarMensajeDeError(this.imgError, this.lblError, "La contrase�a o el correo son incorrectos.");
                }
            }
        }

        private void AccederMenuPrincipal(int indiceUsuario) {
            if (Sistema.ListaUsuarios != null) {
                Usuario usuarioIniciado = Sistema.ListaUsuarios[indiceUsuario];
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(usuarioIniciado, this);

                this.Hide();
                menuPrincipal.Show();
            }
        }


        public static void ActualizarMensajeDeError(PictureBox imgError, Label lblError, string mensaje) {
            imgError.Visible = true;
            lblError.Visible = true;
            lblError.Text = mensaje;
        }

    }
}