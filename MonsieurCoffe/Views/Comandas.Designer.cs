﻿namespace MonsieurCoffe.Views
{
    partial class Comandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandas));
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.nudComanda = new System.Windows.Forms.NumericUpDown();
            this.txbCodProdutoInfo = new System.Windows.Forms.TextBox();
            this.lblProdutoInfo = new System.Windows.Forms.Label();
            this.lblComandaInfo = new System.Windows.Forms.Label();
            this.grbLançamento = new System.Windows.Forms.GroupBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbProdutoLanca = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComanda)).BeginInit();
            this.grbLançamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.btnContinuar);
            this.grbInfo.Controls.Add(this.nudComanda);
            this.grbInfo.Controls.Add(this.txbCodProdutoInfo);
            this.grbInfo.Controls.Add(this.lblProdutoInfo);
            this.grbInfo.Controls.Add(this.lblComandaInfo);
            this.grbInfo.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(12, 78);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(228, 178);
            this.grbInfo.TabIndex = 0;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "INFORMAÇÕES";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(18, 139);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(196, 27);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // nudComanda
            // 
            this.nudComanda.Location = new System.Drawing.Point(18, 57);
            this.nudComanda.Name = "nudComanda";
            this.nudComanda.Size = new System.Drawing.Size(196, 25);
            this.nudComanda.TabIndex = 14;
            this.nudComanda.ValueChanged += new System.EventHandler(this.nudComanda_ValueChanged);
            // 
            // txbCodProdutoInfo
            // 
            this.txbCodProdutoInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbCodProdutoInfo.Location = new System.Drawing.Point(18, 110);
            this.txbCodProdutoInfo.Name = "txbCodProdutoInfo";
            this.txbCodProdutoInfo.Size = new System.Drawing.Size(196, 25);
            this.txbCodProdutoInfo.TabIndex = 3;
            // 
            // lblProdutoInfo
            // 
            this.lblProdutoInfo.AutoSize = true;
            this.lblProdutoInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProdutoInfo.Location = new System.Drawing.Point(15, 92);
            this.lblProdutoInfo.Name = "lblProdutoInfo";
            this.lblProdutoInfo.Size = new System.Drawing.Size(111, 17);
            this.lblProdutoInfo.TabIndex = 1;
            this.lblProdutoInfo.Text = "Cod. Produto:";
            // 
            // lblComandaInfo
            // 
            this.lblComandaInfo.AutoSize = true;
            this.lblComandaInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComandaInfo.Location = new System.Drawing.Point(15, 37);
            this.lblComandaInfo.Name = "lblComandaInfo";
            this.lblComandaInfo.Size = new System.Drawing.Size(80, 17);
            this.lblComandaInfo.TabIndex = 0;
            this.lblComandaInfo.Text = "Comanda:";
            // 
            // grbLançamento
            // 
            this.grbLançamento.Controls.Add(this.nudQuantidade);
            this.grbLançamento.Controls.Add(this.btnCancelar);
            this.grbLançamento.Controls.Add(this.btnLancar);
            this.grbLançamento.Controls.Add(this.txbProdutoLanca);
            this.grbLançamento.Controls.Add(this.lblQuantidade);
            this.grbLançamento.Controls.Add(this.lblProduto);
            this.grbLançamento.Enabled = false;
            this.grbLançamento.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLançamento.Location = new System.Drawing.Point(12, 277);
            this.grbLançamento.Name = "grbLançamento";
            this.grbLançamento.Size = new System.Drawing.Size(228, 211);
            this.grbLançamento.TabIndex = 4;
            this.grbLançamento.TabStop = false;
            this.grbLançamento.Text = "LANÇAMENTO";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(18, 116);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(196, 25);
            this.nudQuantidade.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(18, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(196, 26);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "LIMPAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLancar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.Black;
            this.btnLancar.Location = new System.Drawing.Point(18, 142);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(196, 27);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbProdutoLanca
            // 
            this.txbProdutoLanca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbProdutoLanca.Location = new System.Drawing.Point(18, 56);
            this.txbProdutoLanca.Name = "txbProdutoLanca";
            this.txbProdutoLanca.ReadOnly = true;
            this.txbProdutoLanca.Size = new System.Drawing.Size(196, 25);
            this.txbProdutoLanca.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantidade.Location = new System.Drawing.Point(15, 93);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(98, 17);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto.Location = new System.Drawing.Point(15, 38);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(72, 17);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(403, 44);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Monsieur Coffe :: Comandas";
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AllowUserToResizeColumns = false;
            this.dgvComandas.AllowUserToResizeRows = false;
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(246, 78);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(392, 410);
            this.dgvComandas.TabIndex = 13;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbLançamento);
            this.Controls.Add(this.grbInfo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComanda)).EndInit();
            this.grbLançamento.ResumeLayout(false);
            this.grbLançamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txbCodProdutoInfo;
        private System.Windows.Forms.Label lblProdutoInfo;
        private System.Windows.Forms.Label lblComandaInfo;
        private System.Windows.Forms.GroupBox grbLançamento;
        private System.Windows.Forms.TextBox txbProdutoLanca;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudComanda;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
    }
}