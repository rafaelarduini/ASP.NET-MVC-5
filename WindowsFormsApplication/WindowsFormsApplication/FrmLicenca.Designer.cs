namespace WindowsFormsApplication
{
    partial class FrmLicenca
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
            this.btbLicenca = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbLicenca
            // 
            this.btbLicenca.Location = new System.Drawing.Point(12, 12);
            this.btbLicenca.Name = "btbLicenca";
            this.btbLicenca.Size = new System.Drawing.Size(149, 38);
            this.btbLicenca.TabIndex = 0;
            this.btbLicenca.Text = "Obter licença";
            this.btbLicenca.UseVisualStyleBackColor = true;
            this.btbLicenca.Click += new System.EventHandler(this.btbLicenca_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(12, 66);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(462, 20);
            this.txtChave.TabIndex = 1;
            this.txtChave.Text = "Chave de acesso";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(480, 66);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btbLicenca);
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbLicenca;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnRegistrar;
    }
}