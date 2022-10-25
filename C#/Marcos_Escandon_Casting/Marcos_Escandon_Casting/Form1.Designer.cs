namespace Marcos_Escandon_Casting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toInt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.txtTryParse = new System.Windows.Forms.TextBox();
            this.txtParse = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toInt
            // 
            this.toInt.AutoSize = true;
            this.toInt.Location = new System.Drawing.Point(141, 76);
            this.toInt.Name = "toInt";
            this.toInt.Size = new System.Drawing.Size(36, 15);
            this.toInt.TabIndex = 0;
            this.toInt.Text = "To Int";
            this.toInt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Parse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Try Parse";
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(221, 68);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(100, 23);
            this.txtConvert.TabIndex = 3;
            // 
            // txtTryParse
            // 
            this.txtTryParse.Location = new System.Drawing.Point(221, 183);
            this.txtTryParse.Name = "txtTryParse";
            this.txtTryParse.Size = new System.Drawing.Size(100, 23);
            this.txtTryParse.TabIndex = 4;
            // 
            // txtParse
            // 
            this.txtParse.Location = new System.Drawing.Point(221, 126);
            this.txtParse.Name = "txtParse";
            this.txtParse.Size = new System.Drawing.Size(100, 23);
            this.txtParse.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(345, 67);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Try";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(345, 125);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 7;
            this.btnParse.Text = "Try";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(345, 182);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(75, 23);
            this.btnTryParse.TabIndex = 8;
            this.btnTryParse.Text = "Try";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtParse);
            this.Controls.Add(this.txtTryParse);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label toInt;
        private Label label2;
        private Label label3;
        private TextBox txtConvert;
        private TextBox txtTryParse;
        private TextBox txtParse;
        private Button btnConvert;
        private Button btnParse;
        private Button btnTryParse;
    }
}