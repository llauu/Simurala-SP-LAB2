namespace Interfaz {
    partial class FrmCrearPartida {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearPartida));
            panel1 = new Panel();
            imgError = new PictureBox();
            lblError = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_Cancelar = new Button();
            btn_Crear = new Button();
            cb_Jugador2 = new ComboBox();
            cb_Jugador1 = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_Cancelar);
            panel1.Controls.Add(btn_Crear);
            panel1.Controls.Add(cb_Jugador2);
            panel1.Controls.Add(cb_Jugador1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 230);
            panel1.TabIndex = 0;
            // 
            // imgError
            // 
            imgError.Anchor = AnchorStyles.None;
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(42, 129);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 28;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(63, 129);
            lblError.Name = "lblError";
            lblError.Size = new Size(293, 45);
            lblError.TabIndex = 29;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(184, 93);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 27;
            label3.Text = "VS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 67);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 26;
            label1.Text = "Jugador 2";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 25;
            label2.Text = "Jugador 1";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.None;
            btn_Cancelar.BackColor = Color.Silver;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(171, 184);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(97, 29);
            btn_Cancelar.TabIndex = 23;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Crear
            // 
            btn_Crear.Anchor = AnchorStyles.None;
            btn_Crear.BackColor = Color.CornflowerBlue;
            btn_Crear.FlatAppearance.BorderSize = 0;
            btn_Crear.FlatStyle = FlatStyle.Flat;
            btn_Crear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Crear.Location = new Point(287, 184);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(97, 29);
            btn_Crear.TabIndex = 24;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // cb_Jugador2
            // 
            cb_Jugador2.Anchor = AnchorStyles.None;
            cb_Jugador2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Jugador2.FormattingEnabled = true;
            cb_Jugador2.Location = new Point(235, 89);
            cb_Jugador2.Name = "cb_Jugador2";
            cb_Jugador2.Size = new Size(121, 23);
            cb_Jugador2.TabIndex = 7;
            // 
            // cb_Jugador1
            // 
            cb_Jugador1.Anchor = AnchorStyles.None;
            cb_Jugador1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Jugador1.FormattingEnabled = true;
            cb_Jugador1.Location = new Point(41, 89);
            cb_Jugador1.Name = "cb_Jugador1";
            cb_Jugador1.Size = new Size(121, 23);
            cb_Jugador1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 6);
            label4.Name = "label4";
            label4.Size = new Size(399, 47);
            label4.TabIndex = 5;
            label4.Text = "Crear nueva partida";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCrearPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 254);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearPartida";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCrearSala";
            Load += FrmCrearSala_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private ComboBox cb_Jugador1;
        private ComboBox cb_Jugador2;
        private Button btn_Cancelar;
        private Button btn_Crear;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox imgError;
        private Label lblError;
    }
}