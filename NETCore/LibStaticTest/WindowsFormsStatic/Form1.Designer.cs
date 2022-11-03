namespace WindowsFormsStatic
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnComision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear empleado con comision";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnComision
            // 
            this.btnComision.Location = new System.Drawing.Point(285, 160);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(75, 23);
            this.btnComision.TabIndex = 1;
            this.btnComision.Text = "Crear";
            this.btnComision.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnComision.UseMnemonic = false;
            this.btnComision.UseVisualStyleBackColor = true;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComision);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComision;
    }
}

