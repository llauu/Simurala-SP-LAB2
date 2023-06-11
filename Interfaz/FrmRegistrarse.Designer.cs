namespace Interfaz {
    partial class FrmRegistrarse {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarse));
            panel1 = new Panel();
            panel5 = new Panel();
            txtNombre = new TextBox();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtApellido = new TextBox();
            label1 = new Label();
            imgError = new PictureBox();
            lblError = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            txtCorreo = new TextBox();
            label3 = new Label();
            lblCorreo = new Label();
            txtClave = new TextBox();
            btnCancelar = new Button();
            btnRegistrarse = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblCorreo);
            panel1.Location = new Point(40, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 364);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(txtNombre);
            panel5.Location = new Point(41, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 27);
            panel5.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(3, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 18);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 10);
            label4.Name = "label4";
            label4.Size = new Size(305, 47);
            label4.TabIndex = 3;
            label4.Text = "Regristro";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtApellido);
            panel2.Location = new Point(41, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 27);
            panel2.TabIndex = 13;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.BackColor = Color.WhiteSmoke;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(3, 6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 18);
            txtApellido.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 130);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 12;
            label1.Text = "Apellido";
            // 
            // imgError
            // 
            imgError.Anchor = AnchorStyles.None;
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(44, 318);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 7;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(68, 319);
            lblError.Name = "lblError";
            lblError.Size = new Size(197, 41);
            lblError.TabIndex = 7;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Location = new Point(41, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 27);
            panel4.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(txtCorreo);
            panel3.Location = new Point(41, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 27);
            panel3.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.BackColor = Color.WhiteSmoke;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(3, 6);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(205, 18);
            txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 248);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.None;
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(36, 190);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(121, 19);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo electronico";
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.None;
            txtClave.BackColor = Color.WhiteSmoke;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(84, 302);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(205, 18);
            txtClave.TabIndex = 7;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(40, 411);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.None;
            btnRegistrarse.BackColor = Color.CornflowerBlue;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.Location = new Point(230, 411);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(115, 34);
            btnRegistrarse.TabIndex = 5;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // FrmRegistrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(387, 465);
            Controls.Add(txtClave);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarse);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmRegistrarse";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox imgError;
        private Label lblError;
        private Panel panel4;
        private TextBox txtClave;
        private Panel panel3;
        private TextBox txtCorreo;
        private Label label3;
        private Label lblCorreo;
        private Panel panel5;
        private TextBox txtNombre;
        private Label label2;
        private Panel panel2;
        private TextBox txtApellido;
        private Label label1;
        private Label label4;
        private Button btnCancelar;
        private Button btnRegistrarse;
    }
}