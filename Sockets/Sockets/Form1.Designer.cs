namespace Sockets
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
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lbMsgCliente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o local do arquivo a ser transferido:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(16, 30);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(262, 20);
            this.txtLocal.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(16, 57);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(262, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar com o servidor e transferir arquivo";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lbMsgCliente
            // 
            this.lbMsgCliente.FormattingEnabled = true;
            this.lbMsgCliente.Location = new System.Drawing.Point(16, 87);
            this.lbMsgCliente.Name = "lbMsgCliente";
            this.lbMsgCliente.Size = new System.Drawing.Size(263, 160);
            this.lbMsgCliente.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 264);
            this.Controls.Add(this.lbMsgCliente);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox lbMsgCliente;
    }
}

