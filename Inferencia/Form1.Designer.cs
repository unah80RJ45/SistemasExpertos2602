namespace Inferencia
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
            this.chkLluvia = new System.Windows.Forms.CheckBox();
            this.chkHuracan = new System.Windows.Forms.CheckBox();
            this.chkTerremoto = new System.Windows.Forms.CheckBox();
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // chkLluvia
            // 
            this.chkLluvia.AutoSize = true;
            this.chkLluvia.Location = new System.Drawing.Point(29, 35);
            this.chkLluvia.Name = "chkLluvia";
            this.chkLluvia.Size = new System.Drawing.Size(54, 17);
            this.chkLluvia.TabIndex = 0;
            this.chkLluvia.Text = "Lluvia";
            this.chkLluvia.UseVisualStyleBackColor = true;
            // 
            // chkHuracan
            // 
            this.chkHuracan.AutoSize = true;
            this.chkHuracan.Location = new System.Drawing.Point(122, 35);
            this.chkHuracan.Name = "chkHuracan";
            this.chkHuracan.Size = new System.Drawing.Size(67, 17);
            this.chkHuracan.TabIndex = 1;
            this.chkHuracan.Text = "Huracan";
            this.chkHuracan.UseVisualStyleBackColor = true;
            // 
            // chkTerremoto
            // 
            this.chkTerremoto.AutoSize = true;
            this.chkTerremoto.Location = new System.Drawing.Point(226, 35);
            this.chkTerremoto.Name = "chkTerremoto";
            this.chkTerremoto.Size = new System.Drawing.Size(74, 17);
            this.chkTerremoto.TabIndex = 2;
            this.chkTerremoto.Text = "Terremoto";
            this.chkTerremoto.UseVisualStyleBackColor = true;
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Location = new System.Drawing.Point(334, 31);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(75, 23);
            this.cmdProcesar.TabIndex = 3;
            this.cmdProcesar.Text = "Procesar";
            this.cmdProcesar.UseVisualStyleBackColor = true;
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(397, 261);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 351);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmdProcesar);
            this.Controls.Add(this.chkTerremoto);
            this.Controls.Add(this.chkHuracan);
            this.Controls.Add(this.chkLluvia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLluvia;
        private System.Windows.Forms.CheckBox chkHuracan;
        private System.Windows.Forms.CheckBox chkTerremoto;
        private System.Windows.Forms.Button cmdProcesar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

