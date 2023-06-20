namespace Interfaz {
    partial class FrmEstadisticas {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgv_JugadoresConVictorias = new DataGridView();
            dgv_JugadoresConPuntos = new DataGridView();
            btn_Aceptar = new Button();
            panel2 = new Panel();
            lbl_Jugador1 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btn_crearJuego = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            btn_DescargarHistorial = new PictureBox();
            label2 = new Label();
            dgv_HistorialPartidas = new DataGridView();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgv_JugadoresConVictorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadoresConPuntos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_crearJuego).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_DescargarHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HistorialPartidas).BeginInit();
            SuspendLayout();
            // 
            // dgv_JugadoresConVictorias
            // 
            dgv_JugadoresConVictorias.AllowUserToAddRows = false;
            dgv_JugadoresConVictorias.AllowUserToDeleteRows = false;
            dgv_JugadoresConVictorias.AllowUserToResizeColumns = false;
            dgv_JugadoresConVictorias.AllowUserToResizeRows = false;
            dgv_JugadoresConVictorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_JugadoresConVictorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadoresConVictorias.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_JugadoresConVictorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_JugadoresConVictorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_JugadoresConVictorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_JugadoresConVictorias.EnableHeadersVisualStyles = false;
            dgv_JugadoresConVictorias.Location = new Point(55, 146);
            dgv_JugadoresConVictorias.MultiSelect = false;
            dgv_JugadoresConVictorias.Name = "dgv_JugadoresConVictorias";
            dgv_JugadoresConVictorias.ReadOnly = true;
            dgv_JugadoresConVictorias.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_JugadoresConVictorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_JugadoresConVictorias.RowTemplate.Height = 25;
            dgv_JugadoresConVictorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_JugadoresConVictorias.Size = new Size(170, 275);
            dgv_JugadoresConVictorias.TabIndex = 2;
            // 
            // dgv_JugadoresConPuntos
            // 
            dgv_JugadoresConPuntos.AllowUserToAddRows = false;
            dgv_JugadoresConPuntos.AllowUserToDeleteRows = false;
            dgv_JugadoresConPuntos.AllowUserToResizeColumns = false;
            dgv_JugadoresConPuntos.AllowUserToResizeRows = false;
            dgv_JugadoresConPuntos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_JugadoresConPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadoresConPuntos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_JugadoresConPuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_JugadoresConPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_JugadoresConPuntos.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_JugadoresConPuntos.EnableHeadersVisualStyles = false;
            dgv_JugadoresConPuntos.Location = new Point(273, 146);
            dgv_JugadoresConPuntos.MultiSelect = false;
            dgv_JugadoresConPuntos.Name = "dgv_JugadoresConPuntos";
            dgv_JugadoresConPuntos.ReadOnly = true;
            dgv_JugadoresConPuntos.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgv_JugadoresConPuntos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_JugadoresConPuntos.RowTemplate.Height = 25;
            dgv_JugadoresConPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_JugadoresConPuntos.Size = new Size(170, 275);
            dgv_JugadoresConPuntos.TabIndex = 3;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.None;
            btn_Aceptar.BackColor = Color.CornflowerBlue;
            btn_Aceptar.Cursor = Cursors.Hand;
            btn_Aceptar.FlatAppearance.BorderSize = 0;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Aceptar.Location = new Point(626, 441);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(127, 32);
            btn_Aceptar.TabIndex = 10;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSalmon;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_Jugador1);
            panel2.Location = new Point(55, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 44);
            panel2.TabIndex = 23;
            // 
            // lbl_Jugador1
            // 
            lbl_Jugador1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Jugador1.Location = new Point(-1, 4);
            lbl_Jugador1.Name = "lbl_Jugador1";
            lbl_Jugador1.Size = new Size(170, 30);
            lbl_Jugador1.TabIndex = 13;
            lbl_Jugador1.Text = "Victorias totales";
            lbl_Jugador1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(273, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 44);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 4);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 13;
            label1.Text = "Puntajes totales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btn_crearJuego);
            panel3.Location = new Point(55, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(369, 44);
            panel3.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 4);
            label4.Name = "label4";
            label4.Size = new Size(281, 29);
            label4.TabIndex = 13;
            label4.Text = "Estadisticas historicas";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_crearJuego
            // 
            btn_crearJuego.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_crearJuego.Cursor = Cursors.Hand;
            btn_crearJuego.Image = (Image)resources.GetObject("btn_crearJuego.Image");
            btn_crearJuego.Location = new Point(386, -55);
            btn_crearJuego.Name = "btn_crearJuego";
            btn_crearJuego.Size = new Size(27, 37);
            btn_crearJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btn_crearJuego.TabIndex = 4;
            btn_crearJuego.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(811, 10);
            panel4.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(801, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 492);
            panel5.TabIndex = 27;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 492);
            panel6.Name = "panel6";
            panel6.Size = new Size(801, 10);
            panel6.TabIndex = 28;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gainsboro;
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 482);
            panel7.TabIndex = 29;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkSalmon;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btn_DescargarHistorial);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(491, 103);
            panel8.Name = "panel8";
            panel8.Size = new Size(262, 44);
            panel8.TabIndex = 31;
            // 
            // btn_DescargarHistorial
            // 
            btn_DescargarHistorial.Cursor = Cursors.Hand;
            btn_DescargarHistorial.Image = (Image)resources.GetObject("btn_DescargarHistorial.Image");
            btn_DescargarHistorial.Location = new Point(225, 11);
            btn_DescargarHistorial.Name = "btn_DescargarHistorial";
            btn_DescargarHistorial.Size = new Size(30, 23);
            btn_DescargarHistorial.SizeMode = PictureBoxSizeMode.Zoom;
            btn_DescargarHistorial.TabIndex = 32;
            btn_DescargarHistorial.TabStop = false;
            btn_DescargarHistorial.Click += btn_DescargarHistorial_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-1, 4);
            label2.Name = "label2";
            label2.Size = new Size(229, 30);
            label2.TabIndex = 13;
            label2.Text = "Historial de partidas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_HistorialPartidas
            // 
            dgv_HistorialPartidas.AllowUserToAddRows = false;
            dgv_HistorialPartidas.AllowUserToDeleteRows = false;
            dgv_HistorialPartidas.AllowUserToResizeColumns = false;
            dgv_HistorialPartidas.AllowUserToResizeRows = false;
            dgv_HistorialPartidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_HistorialPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HistorialPartidas.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_HistorialPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_HistorialPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_HistorialPartidas.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_HistorialPartidas.EnableHeadersVisualStyles = false;
            dgv_HistorialPartidas.Location = new Point(491, 146);
            dgv_HistorialPartidas.MultiSelect = false;
            dgv_HistorialPartidas.Name = "dgv_HistorialPartidas";
            dgv_HistorialPartidas.ReadOnly = true;
            dgv_HistorialPartidas.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dgv_HistorialPartidas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgv_HistorialPartidas.RowTemplate.Height = 25;
            dgv_HistorialPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HistorialPartidas.Size = new Size(262, 275);
            dgv_HistorialPartidas.TabIndex = 30;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 35, 39);
            ClientSize = new Size(811, 502);
            Controls.Add(panel8);
            Controls.Add(dgv_HistorialPartidas);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btn_Aceptar);
            Controls.Add(dgv_JugadoresConPuntos);
            Controls.Add(dgv_JugadoresConVictorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEstadisticas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEstadisticas";
            Load += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_JugadoresConVictorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadoresConPuntos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_crearJuego).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_DescargarHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HistorialPartidas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_JugadoresConVictorias;
        private DataGridView dgv_JugadoresConPuntos;
        private Button btn_Aceptar;
        private Panel panel2;
        private Label lbl_Jugador1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private PictureBox btn_crearJuego;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label2;
        private DataGridView dgv_HistorialPartidas;
        private PictureBox btn_DescargarHistorial;
        private ToolTip toolTip1;
    }
}