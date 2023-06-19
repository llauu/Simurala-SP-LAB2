namespace Interfaz {
    partial class FrmNotificacionGanador {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificacionGanador));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbl_Felicitaciones = new Label();
            lbl_Jugador1 = new Label();
            lbl_Jugador2 = new Label();
            lbl_VictoriasTotales = new Label();
            btn_Continuar = new Button();
            lbl_NPartida = new Label();
            dgv_JugadasJ1 = new DataGridView();
            dgv_JugadasJ2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(232, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 1;
            label1.Text = "Hay un nuevo";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(203, 48);
            label2.TabIndex = 2;
            label2.Text = "GANADOR!";
            // 
            // lbl_Felicitaciones
            // 
            lbl_Felicitaciones.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Felicitaciones.Location = new Point(23, 139);
            lbl_Felicitaciones.Name = "lbl_Felicitaciones";
            lbl_Felicitaciones.Size = new Size(389, 42);
            lbl_Felicitaciones.TabIndex = 3;
            lbl_Felicitaciones.Text = "Felicitaciones, (usuario)!";
            // 
            // lbl_Jugador1
            // 
            lbl_Jugador1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Jugador1.Location = new Point(384, 22);
            lbl_Jugador1.Name = "lbl_Jugador1";
            lbl_Jugador1.Size = new Size(153, 29);
            lbl_Jugador1.TabIndex = 6;
            lbl_Jugador1.Text = "Jugador 1";
            lbl_Jugador1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_Jugador2
            // 
            lbl_Jugador2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Jugador2.Location = new Point(569, 22);
            lbl_Jugador2.Name = "lbl_Jugador2";
            lbl_Jugador2.Size = new Size(153, 29);
            lbl_Jugador2.TabIndex = 7;
            lbl_Jugador2.Text = "Jugador 2";
            lbl_Jugador2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_VictoriasTotales
            // 
            lbl_VictoriasTotales.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_VictoriasTotales.Location = new Point(26, 195);
            lbl_VictoriasTotales.Name = "lbl_VictoriasTotales";
            lbl_VictoriasTotales.Size = new Size(315, 30);
            lbl_VictoriasTotales.TabIndex = 8;
            lbl_VictoriasTotales.Text = "Victorias totales de (nombre): X";
            // 
            // btn_Continuar
            // 
            btn_Continuar.Anchor = AnchorStyles.None;
            btn_Continuar.BackColor = Color.CornflowerBlue;
            btn_Continuar.Cursor = Cursors.Hand;
            btn_Continuar.FlatAppearance.BorderSize = 0;
            btn_Continuar.FlatStyle = FlatStyle.Flat;
            btn_Continuar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Continuar.Location = new Point(607, 255);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(115, 32);
            btn_Continuar.TabIndex = 9;
            btn_Continuar.Text = "Continuar";
            btn_Continuar.UseVisualStyleBackColor = false;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // lbl_NPartida
            // 
            lbl_NPartida.AutoSize = true;
            lbl_NPartida.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NPartida.Location = new Point(12, 10);
            lbl_NPartida.Name = "lbl_NPartida";
            lbl_NPartida.Size = new Size(230, 37);
            lbl_NPartida.TabIndex = 10;
            lbl_NPartida.Text = "Partida #111111";
            // 
            // dgv_JugadasJ1
            // 
            dgv_JugadasJ1.AllowUserToAddRows = false;
            dgv_JugadasJ1.AllowUserToDeleteRows = false;
            dgv_JugadasJ1.AllowUserToResizeColumns = false;
            dgv_JugadasJ1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv_JugadasJ1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_JugadasJ1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadasJ1.BackgroundColor = Color.WhiteSmoke;
            dgv_JugadasJ1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_JugadasJ1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_JugadasJ1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_JugadasJ1.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_JugadasJ1.EnableHeadersVisualStyles = false;
            dgv_JugadasJ1.Location = new Point(381, 54);
            dgv_JugadasJ1.MultiSelect = false;
            dgv_JugadasJ1.Name = "dgv_JugadasJ1";
            dgv_JugadasJ1.ReadOnly = true;
            dgv_JugadasJ1.RowHeadersVisible = false;
            dgv_JugadasJ1.RowTemplate.Height = 25;
            dgv_JugadasJ1.Size = new Size(156, 188);
            dgv_JugadasJ1.TabIndex = 21;
            // 
            // dgv_JugadasJ2
            // 
            dgv_JugadasJ2.AllowUserToAddRows = false;
            dgv_JugadasJ2.AllowUserToDeleteRows = false;
            dgv_JugadasJ2.AllowUserToResizeColumns = false;
            dgv_JugadasJ2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgv_JugadasJ2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_JugadasJ2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_JugadasJ2.BackgroundColor = Color.WhiteSmoke;
            dgv_JugadasJ2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_JugadasJ2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_JugadasJ2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_JugadasJ2.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_JugadasJ2.EnableHeadersVisualStyles = false;
            dgv_JugadasJ2.Location = new Point(566, 54);
            dgv_JugadasJ2.MultiSelect = false;
            dgv_JugadasJ2.Name = "dgv_JugadasJ2";
            dgv_JugadasJ2.ReadOnly = true;
            dgv_JugadasJ2.RowHeadersVisible = false;
            dgv_JugadasJ2.RowTemplate.Height = 25;
            dgv_JugadasJ2.Size = new Size(156, 188);
            dgv_JugadasJ2.TabIndex = 22;
            // 
            // FrmNotificacionGanador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 134);
            ClientSize = new Size(742, 299);
            Controls.Add(dgv_JugadasJ2);
            Controls.Add(dgv_JugadasJ1);
            Controls.Add(lbl_NPartida);
            Controls.Add(btn_Continuar);
            Controls.Add(lbl_VictoriasTotales);
            Controls.Add(lbl_Jugador2);
            Controls.Add(lbl_Jugador1);
            Controls.Add(lbl_Felicitaciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNotificacionGanador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmNotificacionGanador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_JugadasJ2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lbl_Felicitaciones;
        private Label lbl_Jugador1;
        private Label lbl_Jugador2;
        private Label lbl_VictoriasTotales;
        private Button btn_Continuar;
        private Label lbl_NPartida;
        private DataGridView dgv_JugadasJ1;
        private DataGridView dgv_JugadasJ2;
    }
}