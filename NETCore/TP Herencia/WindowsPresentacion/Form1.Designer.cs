namespace WindowsPresentacion
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
            this.btnCrearObjeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearObjeto
            // 
            this.btnCrearObjeto.Location = new System.Drawing.Point(499, 225);
            this.btnCrearObjeto.Name = "btnCrearObjeto";
            this.btnCrearObjeto.Size = new System.Drawing.Size(424, 97);
            this.btnCrearObjeto.TabIndex = 0;
            this.btnCrearObjeto.Text = "Crear objeto y mostrar datos";
            this.btnCrearObjeto.UseVisualStyleBackColor = true;
            this.btnCrearObjeto.Click += new System.EventHandler(this.btnCrearObjeto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 547);
            this.Controls.Add(this.btnCrearObjeto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObjeto;
    }
}

