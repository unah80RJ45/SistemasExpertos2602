namespace chaIA
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
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(12, 12);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(524, 20);
            this.txtPregunta.TabIndex = 0;
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 46);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(605, 355);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "";
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Location = new System.Drawing.Point(542, 11);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(75, 23);
            this.cmdEnviar.TabIndex = 2;
            this.cmdEnviar.Text = "Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 413);
            this.Controls.Add(this.cmdEnviar);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.txtPregunta);
            this.Name = "Form1";
            this.Text = "Chat IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Button cmdEnviar;
    }
}

