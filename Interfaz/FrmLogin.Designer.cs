namespace Interfaz {
    partial class FrmLogin {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            imgError = new PictureBox();
            lblError = new Label();
            panel4 = new Panel();
            txtClave = new TextBox();
            panel3 = new Panel();
            txtCorreo = new TextBox();
            label3 = new Label();
            lblCorreo = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblCorreo);
            panel1.Location = new Point(57, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 281);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 10);
            label4.Name = "label4";
            label4.Size = new Size(305, 47);
            label4.TabIndex = 12;
            label4.Text = "Iniciar sesion";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(44, 228);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 7;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(68, 229);
            lblError.Name = "lblError";
            lblError.Size = new Size(200, 52);
            lblError.TabIndex = 7;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(txtClave);
            panel4.Location = new Point(44, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 27);
            panel4.TabIndex = 11;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.WhiteSmoke;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(3, 6);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(205, 18);
            txtClave.TabIndex = 7;
            txtClave.UseSystemPasswordChar = true;
            txtClave.KeyPress += txtClaveOCorreo_KeyPress;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(txtCorreo);
            panel3.Location = new Point(44, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 27);
            panel3.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.WhiteSmoke;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(3, 6);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(205, 18);
            txtCorreo.TabIndex = 5;
            txtCorreo.KeyPress += txtClaveOCorreo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 153);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(39, 76);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(121, 19);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo electronico";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(78, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 85);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Unispace", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 45);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 3;
            label2.Text = "Simulator";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Unispace", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 2;
            label1.Text = "Generala ";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.CornflowerBlue;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(247, 457);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 34);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.None;
            btnRegistrarse.BackColor = Color.Silver;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.Location = new Point(57, 457);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(115, 34);
            btnRegistrarse.TabIndex = 4;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(421, 512);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button btnIngresar;
        private Label label2;
        private Button btnRegistrarse;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label lblCorreo;
        private Panel panel4;
        private Label lblError;
        private PictureBox imgError;
        private Label label4;
    }
}