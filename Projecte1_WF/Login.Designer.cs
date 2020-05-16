namespace Projecte1_WF
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUsuari = new BibliotecaDeClases.SdsTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbContrassenya = new BibliotecaDeClases.SdsTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.missatgerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.tbUsuari);
            this.panel2.Location = new System.Drawing.Point(370, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 31);
            this.panel2.TabIndex = 1;
            // 
            // tbUsuari
            // 
            this.tbUsuari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsuari.BackColor = System.Drawing.Color.Black;
            this.tbUsuari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuari.CampBBDD = null;
            this.tbUsuari.ControlId = null;
            this.tbUsuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuari.Forana = false;
            this.tbUsuari.ForeColor = System.Drawing.Color.Red;
            this.tbUsuari.Location = new System.Drawing.Point(3, 4);
            this.tbUsuari.MaxLength = 12;
            this.tbUsuari.Name = "tbUsuari";
            this.tbUsuari.PlaceHolder = "Usuari";
            this.tbUsuari.Requerit = false;
            this.tbUsuari.Size = new System.Drawing.Size(246, 23);
            this.tbUsuari.TabIndex = 4;
            this.tbUsuari.Text = "Usuari";
            this.tbUsuari.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(440, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 51);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(676, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(299, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.tbContrassenya);
            this.panel1.Location = new System.Drawing.Point(370, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 31);
            this.panel1.TabIndex = 5;
            // 
            // tbContrassenya
            // 
            this.tbContrassenya.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContrassenya.BackColor = System.Drawing.Color.Black;
            this.tbContrassenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContrassenya.CampBBDD = null;
            this.tbContrassenya.ControlId = null;
            this.tbContrassenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrassenya.Forana = false;
            this.tbContrassenya.ForeColor = System.Drawing.Color.Red;
            this.tbContrassenya.Location = new System.Drawing.Point(3, 4);
            this.tbContrassenya.MaxLength = 12;
            this.tbContrassenya.Name = "tbContrassenya";
            this.tbContrassenya.PlaceHolder = "Contrasenya";
            this.tbContrassenya.Requerit = false;
            this.tbContrassenya.Size = new System.Drawing.Size(246, 23);
            this.tbContrassenya.TabIndex = 5;
            this.tbContrassenya.Text = "Contrasenya";
            this.tbContrassenya.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Contrassenya;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // missatgerror
            // 
            this.missatgerror.AutoSize = true;
            this.missatgerror.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.missatgerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missatgerror.ForeColor = System.Drawing.Color.Red;
            this.missatgerror.Location = new System.Drawing.Point(395, 308);
            this.missatgerror.Name = "missatgerror";
            this.missatgerror.Size = new System.Drawing.Size(209, 16);
            this.missatgerror.TabIndex = 7;
            this.missatgerror.Text = "¡EL LOGIN ES INCORRECTE!";
            this.missatgerror.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(713, 398);
            this.Controls.Add(this.missatgerror);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private BibliotecaDeClases.SdsTextbox tbUsuari;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private BibliotecaDeClases.SdsTextbox tbContrassenya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label missatgerror;
    }
}