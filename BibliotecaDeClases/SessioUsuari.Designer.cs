namespace BibliotecaDeClases
{
    partial class SessioUsuari
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.avatarusuari = new System.Windows.Forms.PictureBox();
            this.nomusuari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarusuari)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarusuari
            // 
            this.avatarusuari.Location = new System.Drawing.Point(153, 2);
            this.avatarusuari.Name = "avatarusuari";
            this.avatarusuari.Size = new System.Drawing.Size(35, 35);
            this.avatarusuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarusuari.TabIndex = 1;
            this.avatarusuari.TabStop = false;
            // 
            // nomusuari
            // 
            this.nomusuari.AutoSize = true;
            this.nomusuari.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomusuari.Location = new System.Drawing.Point(13, 9);
            this.nomusuari.Name = "nomusuari";
            this.nomusuari.Size = new System.Drawing.Size(0, 22);
            this.nomusuari.TabIndex = 2;
            this.nomusuari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SessioUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.nomusuari);
            this.Controls.Add(this.avatarusuari);
            this.Name = "SessioUsuari";
            this.Size = new System.Drawing.Size(198, 40);
            ((System.ComponentModel.ISupportInitialize)(this.avatarusuari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox avatarusuari;
        private System.Windows.Forms.Label nomusuari;
    }
}
