namespace WindowsFormsApplication
{
    partial class FrmDoacao
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
            this.btnDoacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoacao
            // 
            this.btnDoacao.Location = new System.Drawing.Point(157, 94);
            this.btnDoacao.Name = "btnDoacao";
            this.btnDoacao.Size = new System.Drawing.Size(328, 149);
            this.btnDoacao.TabIndex = 0;
            this.btnDoacao.Text = "Clique aqui para fazer a doação";
            this.btnDoacao.UseVisualStyleBackColor = true;
            this.btnDoacao.Click += new System.EventHandler(this.btnDoacao_Click);
            // 
            // FrmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.btnDoacao);
            this.Name = "FrmDoacao";
            this.Text = "FrmDoacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoacao;
    }
}