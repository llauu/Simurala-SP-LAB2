namespace Interfaz {
    partial class FrmMenuPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            panelBotones = new Panel();
            btn_crearJuego = new PictureBox();
            btn_iniciarJuego = new PictureBox();
            btn_agregarJugador = new PictureBox();
            toolTip1 = new ToolTip(components);
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_crearJuego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_iniciarJuego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregarJugador).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.DarkGray;
            panelBotones.Controls.Add(btn_crearJuego);
            panelBotones.Controls.Add(btn_iniciarJuego);
            panelBotones.Controls.Add(btn_agregarJugador);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 445);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1025, 77);
            panelBotones.TabIndex = 0;
            // 
            // btn_crearJuego
            // 
            btn_crearJuego.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_crearJuego.Cursor = Cursors.Hand;
            btn_crearJuego.Image = (Image)resources.GetObject("btn_crearJuego.Image");
            btn_crearJuego.Location = new Point(111, 15);
            btn_crearJuego.Name = "btn_crearJuego";
            btn_crearJuego.Size = new Size(69, 50);
            btn_crearJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btn_crearJuego.TabIndex = 4;
            btn_crearJuego.TabStop = false;
            // 
            // btn_iniciarJuego
            // 
            btn_iniciarJuego.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_iniciarJuego.Cursor = Cursors.Hand;
            btn_iniciarJuego.Image = (Image)resources.GetObject("btn_iniciarJuego.Image");
            btn_iniciarJuego.Location = new Point(936, 15);
            btn_iniciarJuego.Name = "btn_iniciarJuego";
            btn_iniciarJuego.Size = new Size(66, 50);
            btn_iniciarJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btn_iniciarJuego.TabIndex = 3;
            btn_iniciarJuego.TabStop = false;
            // 
            // btn_agregarJugador
            // 
            btn_agregarJugador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_agregarJugador.Cursor = Cursors.Hand;
            btn_agregarJugador.Image = (Image)resources.GetObject("btn_agregarJugador.Image");
            btn_agregarJugador.Location = new Point(25, 15);
            btn_agregarJugador.Name = "btn_agregarJugador";
            btn_agregarJugador.Size = new Size(71, 50);
            btn_agregarJugador.SizeMode = PictureBoxSizeMode.Zoom;
            btn_agregarJugador.TabIndex = 2;
            btn_agregarJugador.TabStop = false;
            btn_agregarJugador.Click += btn_agregarJugador_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1025, 522);
            Controls.Add(panelBotones);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_crearJuego).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_iniciarJuego).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregarJugador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private PictureBox btn_crearJuego;
        private PictureBox btn_iniciarJuego;
        private PictureBox btn_agregarJugador;
        private ToolTip toolTip1;
    }
}