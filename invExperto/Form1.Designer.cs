namespace invExperto
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
            this.cmdMotor = new System.Windows.Forms.Button();
            this.cmdIA = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmdMotor
            // 
            this.cmdMotor.Location = new System.Drawing.Point(12, 12);
            this.cmdMotor.Name = "cmdMotor";
            this.cmdMotor.Size = new System.Drawing.Size(220, 46);
            this.cmdMotor.TabIndex = 0;
            this.cmdMotor.Text = "Evaluar Motor";
            this.cmdMotor.UseVisualStyleBackColor = true;
            this.cmdMotor.Click += new System.EventHandler(this.cmdMotor_Click);
            // 
            // cmdIA
            // 
            this.cmdIA.Location = new System.Drawing.Point(238, 12);
            this.cmdIA.Name = "cmdIA";
            this.cmdIA.Size = new System.Drawing.Size(220, 46);
            this.cmdIA.TabIndex = 1;
            this.cmdIA.Text = "Evaluar IA";
            this.cmdIA.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(446, 296);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 376);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmdIA);
            this.Controls.Add(this.cmdMotor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdMotor;
        private System.Windows.Forms.Button cmdIA;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

