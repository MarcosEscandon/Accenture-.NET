namespace WindowsAppClinica
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
            this.btnCrearPediatra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearPediatra
            // 
            this.btnCrearPediatra.Location = new System.Drawing.Point(228, 156);
            this.btnCrearPediatra.Name = "btnCrearPediatra";
            this.btnCrearPediatra.Size = new System.Drawing.Size(174, 58);
            this.btnCrearPediatra.TabIndex = 0;
            this.btnCrearPediatra.Text = "Crear y Mostrar Medico Pediatra";
            this.btnCrearPediatra.UseVisualStyleBackColor = true;
            this.btnCrearPediatra.Click += new System.EventHandler(this.btnCrearPediatra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearPediatra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPediatra;
    }
}

