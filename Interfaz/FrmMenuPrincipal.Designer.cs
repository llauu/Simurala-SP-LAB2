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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelBotones = new Panel();
            btn_Estadisticas = new PictureBox();
            imgError = new PictureBox();
            btn_frenarJuego = new PictureBox();
            lblError = new Label();
            btn_iniciarJuego = new PictureBox();
            btn_agregarJugador = new PictureBox();
            btn_crearJuego = new PictureBox();
            toolTip1 = new ToolTip(components);
            dgv_Partidas = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            dado_uno = new PictureBox();
            dado_dos = new PictureBox();
            dado_tres = new PictureBox();
            dado_cuatro = new PictureBox();
            dado_cinco = new PictureBox();
            dgv_JugadasJ1 = new DataGridView();
            dgv_JugadasJ2 = new DataGridView();
            panel2 = new Panel();
            lbl_Jugador1 = new Label();
            panel3 = new Panel();
            lbl_Jugador2 = new Label();
            rtb_Jugadas = new RichTextBox();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Estadisticas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_frenarJuego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_iniciarJuego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregarJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_crearJuego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Partidas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado_uno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado_dos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado_tres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado_cuatro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado_cinco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.LightGray;
            panelBotones.Controls.Add(btn_Estadisticas);
            panelBotones.Controls.Add(imgError);
            panelBotones.Controls.Add(btn_frenarJuego);
            panelBotones.Controls.Add(lblError);
            panelBotones.Controls.Add(btn_iniciarJuego);
            panelBotones.Controls.Add(btn_agregarJugador);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 502);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1280, 73);
            panelBotones.TabIndex = 0;
            // 
            // btn_Estadisticas
            // 
            btn_Estadisticas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Estadisticas.Cursor = Cursors.Hand;
            btn_Estadisticas.Image = (Image)resources.GetObject("btn_Estadisticas.Image");
            btn_Estadisticas.Location = new Point(21, 14);
            btn_Estadisticas.Name = "btn_Estadisticas";
            btn_Estadisticas.Size = new Size(48, 46);
            btn_Estadisticas.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Estadisticas.TabIndex = 27;
            btn_Estadisticas.TabStop = false;
            btn_Estadisticas.Click += btn_Estadisticas_Click;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(732, 12);
            imgError.Name = "imgError";
            imgError.Size = new Size(22, 22);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 25;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // btn_frenarJuego
            // 
            btn_frenarJuego.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_frenarJuego.Cursor = Cursors.Hand;
            btn_frenarJuego.Image = (Image)resources.GetObject("btn_frenarJuego.Image");
            btn_frenarJuego.Location = new Point(1137, 11);
            btn_frenarJuego.Name = "btn_frenarJuego";
            btn_frenarJuego.Size = new Size(56, 50);
            btn_frenarJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btn_frenarJuego.TabIndex = 5;
            btn_frenarJuego.TabStop = false;
            btn_frenarJuego.Click += btn_frenarJuego_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(760, 12);
            lblError.Name = "lblError";
            lblError.Size = new Size(342, 52);
            lblError.TabIndex = 26;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // btn_iniciarJuego
            // 
            btn_iniciarJuego.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_iniciarJuego.Cursor = Cursors.Hand;
            btn_iniciarJuego.Image = (Image)resources.GetObject("btn_iniciarJuego.Image");
            btn_iniciarJuego.Location = new Point(1201, 11);
            btn_iniciarJuego.Name = "btn_iniciarJuego";
            btn_iniciarJuego.Size = new Size(56, 50);
            btn_iniciarJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btn_iniciarJuego.TabIndex = 3;
            btn_iniciarJuego.TabStop = false;
            btn_iniciarJuego.Click += btn_iniciarJuego_Click;
            // 
            // btn_agregarJugador
            // 
            btn_agregarJugador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_agregarJugador.Cursor = Cursors.Hand;
            btn_agregarJugador.Image = (Image)resources.GetObject("btn_agregarJugador.Image");
            btn_agregarJugador.Location = new Point(85, 14);
            btn_agregarJugador.Name = "btn_agregarJugador";
            btn_agregarJugador.Size = new Size(54, 50);
            btn_agregarJugador.SizeMode = PictureBoxSizeMode.Zoom;
            btn_agregarJugador.TabIndex = 2;
            btn_agregarJugador.TabStop = false;
            btn_agregarJugador.Click += btn_agregarJugador_Click;
            // 
            // btn_crearJuego
            // 
            btn_crearJuego.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_crearJuego.Cursor = Cursors.Hand;
            btn_crearJuego.Image = (Image)resources.GetObject("btn_crearJuego.Image");
            btn_crearJuego.Location = new Point(219, 3);
            btn_crearJuego.Name = "btn_crearJuego";
            btn_crearJuego.Size = new Size(27, 37);
            btn_crearJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btn_crearJuego.TabIndex = 4;
            btn_crearJuego.TabStop = false;
            btn_crearJuego.Click += btn_crearJuego_Click;
            // 
            // dgv_Partidas
            // 
            dgv_Partidas.AllowUserToAddRows = false;
            dgv_Partidas.AllowUserToDeleteRows = false;
            dgv_Partidas.AllowUserToResizeColumns = false;
            dgv_Partidas.AllowUserToResizeRows = false;
            dgv_Partidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_Partidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Partidas.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Partidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Partidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Partidas.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Partidas.EnableHeadersVisualStyles = false;
            dgv_Partidas.Location = new Point(38, 99);
            dgv_Partidas.MultiSelect = false;
            dgv_Partidas.Name = "dgv_Partidas";
            dgv_Partidas.ReadOnly = true;
            dgv_Partidas.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_Partidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Partidas.RowTemplate.Height = 25;
            dgv_Partidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Partidas.Size = new Size(256, 346);
            dgv_Partidas.TabIndex = 1;
            dgv_Partidas.CellClick += dgv_Partidas_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_crearJuego);
            panel1.Location = new Point(38, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 44);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-1, 3);
            label4.Name = "label4";
            label4.Size = new Size(197, 37);
            label4.TabIndex = 13;
            label4.Text = "Salas de juego";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(527, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dado_uno
            // 
            dado_uno.BackColor = Color.FromArgb(135, 42, 40);
            dado_uno.Image = (Image)resources.GetObject("dado_uno.Image");
            dado_uno.Location = new Point(432, 223);
            dado_uno.Name = "dado_uno";
            dado_uno.Size = new Size(51, 51);
            dado_uno.SizeMode = PictureBoxSizeMode.Zoom;
            dado_uno.TabIndex = 15;
            dado_uno.TabStop = false;
            dado_uno.Visible = false;
            // 
            // dado_dos
            // 
            dado_dos.BackColor = Color.FromArgb(180, 56, 53);
            dado_dos.Image = (Image)resources.GetObject("dado_dos.Image");
            dado_dos.Location = new Point(497, 223);
            dado_dos.Name = "dado_dos";
            dado_dos.Size = new Size(51, 51);
            dado_dos.SizeMode = PictureBoxSizeMode.Zoom;
            dado_dos.TabIndex = 16;
            dado_dos.TabStop = false;
            dado_dos.Visible = false;
            // 
            // dado_tres
            // 
            dado_tres.BackColor = Color.FromArgb(192, 68, 64);
            dado_tres.Image = (Image)resources.GetObject("dado_tres.Image");
            dado_tres.Location = new Point(563, 223);
            dado_tres.Name = "dado_tres";
            dado_tres.Size = new Size(51, 51);
            dado_tres.SizeMode = PictureBoxSizeMode.Zoom;
            dado_tres.TabIndex = 17;
            dado_tres.TabStop = false;
            dado_tres.Visible = false;
            // 
            // dado_cuatro
            // 
            dado_cuatro.BackColor = Color.FromArgb(180, 56, 53);
            dado_cuatro.Image = (Image)resources.GetObject("dado_cuatro.Image");
            dado_cuatro.Location = new Point(629, 223);
            dado_cuatro.Name = "dado_cuatro";
            dado_cuatro.Size = new Size(51, 51);
            dado_cuatro.SizeMode = PictureBoxSizeMode.Zoom;
            dado_cuatro.TabIndex = 18;
            dado_cuatro.TabStop = false;
            dado_cuatro.Visible = false;
            // 
            // dado_cinco
            // 
            dado_cinco.BackColor = Color.FromArgb(135, 42, 40);
            dado_cinco.Image = (Image)resources.GetObject("dado_cinco.Image");
            dado_cinco.Location = new Point(695, 223);
            dado_cinco.Name = "dado_cinco";
            dado_cinco.Size = new Size(51, 51);
            dado_cinco.SizeMode = PictureBoxSizeMode.Zoom;
            dado_cinco.TabIndex = 19;
            dado_cinco.TabStop = false;
            dado_cinco.Visible = false;
            // 
            // dgv_JugadasJ1
            // 
            dgv_JugadasJ1.AllowUserToAddRows = false;
            dgv_JugadasJ1.AllowUserToDeleteRows = false;
            dgv_JugadasJ1.AllowUserToResizeColumns = false;
            dgv_JugadasJ1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgv_JugadasJ1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_JugadasJ1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadasJ1.BackgroundColor = Color.WhiteSmoke;
            dgv_JugadasJ1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_JugadasJ1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_JugadasJ1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_JugadasJ1.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_JugadasJ1.EnableHeadersVisualStyles = false;
            dgv_JugadasJ1.Location = new Point(888, 100);
            dgv_JugadasJ1.MultiSelect = false;
            dgv_JugadasJ1.Name = "dgv_JugadasJ1";
            dgv_JugadasJ1.ReadOnly = true;
            dgv_JugadasJ1.RowHeadersVisible = false;
            dgv_JugadasJ1.RowTemplate.Height = 25;
            dgv_JugadasJ1.Size = new Size(156, 208);
            dgv_JugadasJ1.TabIndex = 20;
            dgv_JugadasJ1.RowPrePaint += dgv_JugadasJ1_RowPrePaint;
            // 
            // dgv_JugadasJ2
            // 
            dgv_JugadasJ2.AllowUserToAddRows = false;
            dgv_JugadasJ2.AllowUserToDeleteRows = false;
            dgv_JugadasJ2.AllowUserToResizeColumns = false;
            dgv_JugadasJ2.AllowUserToResizeRows = false;
            dgv_JugadasJ2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadasJ2.BackgroundColor = Color.WhiteSmoke;
            dgv_JugadasJ2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_JugadasJ2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_JugadasJ2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_JugadasJ2.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_JugadasJ2.EnableHeadersVisualStyles = false;
            dgv_JugadasJ2.Location = new Point(1085, 100);
            dgv_JugadasJ2.MultiSelect = false;
            dgv_JugadasJ2.Name = "dgv_JugadasJ2";
            dgv_JugadasJ2.ReadOnly = true;
            dgv_JugadasJ2.RowHeadersVisible = false;
            dgv_JugadasJ2.RowTemplate.Height = 25;
            dgv_JugadasJ2.Size = new Size(156, 208);
            dgv_JugadasJ2.TabIndex = 21;
            dgv_JugadasJ2.RowPrePaint += dgv_JugadasJ2_RowPrePaint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSalmon;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_Jugador1);
            panel2.Location = new Point(888, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 44);
            panel2.TabIndex = 22;
            // 
            // lbl_Jugador1
            // 
            lbl_Jugador1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Jugador1.Location = new Point(-1, 3);
            lbl_Jugador1.Name = "lbl_Jugador1";
            lbl_Jugador1.Size = new Size(156, 37);
            lbl_Jugador1.TabIndex = 13;
            lbl_Jugador1.Text = "Jugador 1";
            lbl_Jugador1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_Jugador2);
            panel3.Location = new Point(1085, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(156, 44);
            panel3.TabIndex = 23;
            // 
            // lbl_Jugador2
            // 
            lbl_Jugador2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Jugador2.Location = new Point(-1, 3);
            lbl_Jugador2.Name = "lbl_Jugador2";
            lbl_Jugador2.Size = new Size(156, 37);
            lbl_Jugador2.TabIndex = 13;
            lbl_Jugador2.Text = "Jugador 2";
            lbl_Jugador2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtb_Jugadas
            // 
            rtb_Jugadas.BackColor = Color.Gainsboro;
            rtb_Jugadas.BorderStyle = BorderStyle.None;
            rtb_Jugadas.Location = new Point(888, 333);
            rtb_Jugadas.Name = "rtb_Jugadas";
            rtb_Jugadas.ReadOnly = true;
            rtb_Jugadas.Size = new Size(353, 141);
            rtb_Jugadas.TabIndex = 24;
            rtb_Jugadas.Text = "";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 35, 39);
            ClientSize = new Size(1280, 575);
            Controls.Add(rtb_Jugadas);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgv_JugadasJ2);
            Controls.Add(dgv_JugadasJ1);
            Controls.Add(dado_cinco);
            Controls.Add(dado_cuatro);
            Controls.Add(dado_tres);
            Controls.Add(dado_dos);
            Controls.Add(dado_uno);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dgv_Partidas);
            Controls.Add(panelBotones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1296, 614);
            MinimumSize = new Size(1296, 614);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generala Simulator";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FrmMenuPrincipal_Load;
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Estadisticas).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_frenarJuego).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_iniciarJuego).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregarJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_crearJuego).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Partidas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado_uno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado_dos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado_tres).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado_cuatro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado_cinco).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private PictureBox btn_crearJuego;
        private PictureBox btn_iniciarJuego;
        private PictureBox btn_agregarJugador;
        private ToolTip toolTip1;
        private DataGridView dgv_Partidas;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox dado_uno;
        private PictureBox dado_dos;
        private PictureBox dado_tres;
        private PictureBox dado_cuatro;
        private PictureBox dado_cinco;
        private DataGridView dgv_JugadasJ1;
        private DataGridView dgv_JugadasJ2;
        private Panel panel2;
        private Label lbl_Jugador1;
        private Panel panel3;
        private Label lbl_Jugador2;
        private PictureBox btn_frenarJuego;
        private RichTextBox rtb_Jugadas;
        private PictureBox imgError;
        private Label lblError;
        private PictureBox btn_Estadisticas;
    }
}