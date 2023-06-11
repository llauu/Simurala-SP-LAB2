namespace Interfaz {
    partial class FrmCrearJugador {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearJugador));
            panel1 = new Panel();
            imgError = new PictureBox();
            lblError = new Label();
            btn_Crear = new Button();
            panel5 = new Panel();
            txt_nombre = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(btn_Crear);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 244);
            panel1.TabIndex = 0;
            // 
            // imgError
            // 
            imgError.Anchor = AnchorStyles.None;
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(31, 140);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 19;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(52, 140);
            lblError.Name = "lblError";
            lblError.Size = new Size(184, 56);
            lblError.TabIndex = 20;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // btn_Crear
            // 
            btn_Crear.Anchor = AnchorStyles.None;
            btn_Crear.BackColor = Color.Silver;
            btn_Crear.FlatAppearance.BorderSize = 0;
            btn_Crear.FlatStyle = FlatStyle.Flat;
            btn_Crear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Crear.Location = new Point(78, 199);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(108, 29);
            btn_Crear.TabIndex = 18;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(txt_nombre);
            panel5.Controls.Add(txtNombre);
            panel5.Location = new Point(30, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 27);
            panel5.TabIndex = 17;
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(3, 6);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(172, 18);
            txt_nombre.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(7, -31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 18);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 16);
            label4.Name = "label4";
            label4.Size = new Size(269, 47);
            label4.TabIndex = 4;
            label4.Text = "Crear jugador";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCrearJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(293, 268);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearJugador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCrearJugador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button btn_Crear;
        private Panel panel5;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txt_nombre;
        private PictureBox imgError;
        private Label lblError;
    }
}