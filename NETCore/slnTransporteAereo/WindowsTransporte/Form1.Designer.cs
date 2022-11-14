namespace WindowsTransporte
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
            this.btnMostrarHelicoptero = new System.Windows.Forms.Button();
            this.btnMostrarJet = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarHelicoptero
            // 
            this.btnMostrarHelicoptero.Location = new System.Drawing.Point(92, 171);
            this.btnMostrarHelicoptero.Name = "btnMostrarHelicoptero";
            this.btnMostrarHelicoptero.Size = new System.Drawing.Size(134, 51);
            this.btnMostrarHelicoptero.TabIndex = 0;
            this.btnMostrarHelicoptero.Text = "Mostrar info Helicoptero";
            this.btnMostrarHelicoptero.UseVisualStyleBackColor = true;
            this.btnMostrarHelicoptero.Click += new System.EventHandler(this.btnMostrarHelicoptero_Click);
            // 
            // btnMostrarJet
            // 
            this.btnMostrarJet.Location = new System.Drawing.Point(341, 171);
            this.btnMostrarJet.Name = "btnMostrarJet";
            this.btnMostrarJet.Size = new System.Drawing.Size(133, 51);
            this.btnMostrarJet.TabIndex = 1;
            this.btnMostrarJet.Text = "Mostrar Info Jet";
            this.btnMostrarJet.UseVisualStyleBackColor = true;
            this.btnMostrarJet.Click += new System.EventHandler(this.btnMostrarJet_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(240, 266);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(111, 23);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Eliminar Azafata";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 344);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnMostrarJet);
            this.Controls.Add(this.btnMostrarHelicoptero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarHelicoptero;
        private System.Windows.Forms.Button btnMostrarJet;
        private System.Windows.Forms.Button btnQuitar;
    }
}

