namespace trackbar
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Tamaño = new System.Windows.Forms.Label();
            this.tBTamaño = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tBTamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tamaño
            // 
            this.lbl_Tamaño.AutoSize = true;
            this.lbl_Tamaño.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Tamaño.Location = new System.Drawing.Point(53, 42);
            this.lbl_Tamaño.Name = "lbl_Tamaño";
            this.lbl_Tamaño.Size = new System.Drawing.Size(116, 16);
            this.lbl_Tamaño.TabIndex = 0;
            this.lbl_Tamaño.Text = "Tamaño de fuente";
            // 
            // tBTamaño
            // 
            this.tBTamaño.Location = new System.Drawing.Point(33, 149);
            this.tBTamaño.Maximum = 50;
            this.tBTamaño.Name = "tBTamaño";
            this.tBTamaño.Size = new System.Drawing.Size(423, 56);
            this.tBTamaño.TabIndex = 1;
            this.tBTamaño.Scroll += new System.EventHandler(this.tBvolumen_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1029, 231);
            this.Controls.Add(this.tBTamaño);
            this.Controls.Add(this.lbl_Tamaño);
            this.Name = "Form1";
            this.Text = "Ejemplo del control trackBar";
            ((System.ComponentModel.ISupportInitialize)(this.tBTamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tamaño;
        private System.Windows.Forms.TrackBar tBTamaño;
    }
}

