﻿namespace Consumindo_WebApi_Produtos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnObterProdutos = new System.Windows.Forms.Button();
            this.btnProdutosPorId = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.btnAtualizaProduto = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI - Web API:";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(99, 6);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(590, 20);
            this.txtURI.TabIndex = 1;
            this.txtURI.Text = "https://localhost:44305/produtos";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 32);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(674, 350);
            this.dgvDados.TabIndex = 2;
            // 
            // btnObterProdutos
            // 
            this.btnObterProdutos.Location = new System.Drawing.Point(15, 401);
            this.btnObterProdutos.Name = "btnObterProdutos";
            this.btnObterProdutos.Size = new System.Drawing.Size(130, 37);
            this.btnObterProdutos.TabIndex = 3;
            this.btnObterProdutos.Text = "Retorna Produtos";
            this.btnObterProdutos.UseVisualStyleBackColor = true;
            this.btnObterProdutos.Click += new System.EventHandler(this.btnObterProdutos_Click);
            // 
            // btnProdutosPorId
            // 
            this.btnProdutosPorId.Location = new System.Drawing.Point(151, 401);
            this.btnProdutosPorId.Name = "btnProdutosPorId";
            this.btnProdutosPorId.Size = new System.Drawing.Size(130, 37);
            this.btnProdutosPorId.TabIndex = 4;
            this.btnProdutosPorId.Text = "Obter Produto Por ID";
            this.btnProdutosPorId.UseVisualStyleBackColor = true;
            this.btnProdutosPorId.Click += new System.EventHandler(this.btnProdutosPorId_Click_1);
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Location = new System.Drawing.Point(287, 401);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(130, 37);
            this.btnIncluirProduto.TabIndex = 5;
            this.btnIncluirProduto.Text = "Incluir Produto";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // btnAtualizaProduto
            // 
            this.btnAtualizaProduto.Location = new System.Drawing.Point(423, 401);
            this.btnAtualizaProduto.Name = "btnAtualizaProduto";
            this.btnAtualizaProduto.Size = new System.Drawing.Size(130, 37);
            this.btnAtualizaProduto.TabIndex = 6;
            this.btnAtualizaProduto.Text = "Atualizar Produto";
            this.btnAtualizaProduto.UseVisualStyleBackColor = true;
            this.btnAtualizaProduto.Click += new System.EventHandler(this.btnAtualizaProduto_Click);
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(559, 401);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(130, 37);
            this.btnDeletarProduto.TabIndex = 7;
            this.btnDeletarProduto.Text = "Deletar Produto";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            this.btnDeletarProduto.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAtualizaProduto);
            this.Controls.Add(this.btnIncluirProduto);
            this.Controls.Add(this.btnProdutosPorId);
            this.Controls.Add(this.btnObterProdutos);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnObterProdutos;
        private System.Windows.Forms.Button btnProdutosPorId;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Button btnAtualizaProduto;
        private System.Windows.Forms.Button btnDeletarProduto;
    }
}

