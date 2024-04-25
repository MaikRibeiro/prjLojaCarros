
namespace prjLojaCarros
{
    partial class frmVeiculo
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
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.lblCodVeiculo = new System.Windows.Forms.Label();
            this.lblNomeVeiculo = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.gbbTipo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbbMarca = new System.Windows.Forms.GroupBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.gbbTipo.SuspendLayout();
            this.gbbMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodVeiculo.Location = new System.Drawing.Point(12, -6);
            this.txtCodVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.Size = new System.Drawing.Size(10, 13);
            this.txtCodVeiculo.TabIndex = 0;
            this.txtCodVeiculo.Visible = false;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(94, 53);
            this.txtVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(161, 20);
            this.txtVeiculo.TabIndex = 1;
            // 
            // lblCodVeiculo
            // 
            this.lblCodVeiculo.AutoSize = true;
            this.lblCodVeiculo.Location = new System.Drawing.Point(7, 9);
            this.lblCodVeiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodVeiculo.Name = "lblCodVeiculo";
            this.lblCodVeiculo.Size = new System.Drawing.Size(0, 13);
            this.lblCodVeiculo.TabIndex = 2;
            this.lblCodVeiculo.Visible = false;
            // 
            // lblNomeVeiculo
            // 
            this.lblNomeVeiculo.AutoSize = true;
            this.lblNomeVeiculo.Location = new System.Drawing.Point(21, 56);
            this.lblNomeVeiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeVeiculo.Name = "lblNomeVeiculo";
            this.lblNomeVeiculo.Size = new System.Drawing.Size(44, 13);
            this.lblNomeVeiculo.TabIndex = 3;
            this.lblNomeVeiculo.Text = "Veículo";
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(82, 36);
            this.cbbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(161, 21);
            this.cbbTipo.TabIndex = 3;
            // 
            // cbbMarca
            // 
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(69, 35);
            this.cbbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(161, 21);
            this.cbbMarca.TabIndex = 4;
            // 
            // gbbTipo
            // 
            this.gbbTipo.Controls.Add(this.cbbTipo);
            this.gbbTipo.Location = new System.Drawing.Point(12, 100);
            this.gbbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.gbbTipo.Name = "gbbTipo";
            this.gbbTipo.Padding = new System.Windows.Forms.Padding(2);
            this.gbbTipo.Size = new System.Drawing.Size(266, 83);
            this.gbbTipo.TabIndex = 8;
            this.gbbTipo.TabStop = false;
            this.gbbTipo.Text = "Tipo";
            // 
            // gbbMarca
            // 
            this.gbbMarca.Controls.Add(this.cbbMarca);
            this.gbbMarca.Location = new System.Drawing.Point(302, 100);
            this.gbbMarca.Name = "gbbMarca";
            this.gbbMarca.Size = new System.Drawing.Size(250, 83);
            this.gbbMarca.TabIndex = 9;
            this.gbbMarca.TabStop = false;
            this.gbbMarca.Text = "Marca";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(309, 56);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano";
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(371, 53);
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(70, 20);
            this.txtAnoVeiculo.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(174, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(255, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(336, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(137, 221);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(46, 23);
            this.btnPrimeiro.TabIndex = 17;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(244, 221);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(46, 23);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(352, 221);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(46, 23);
            this.btnProximo.TabIndex = 19;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(460, 221);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(46, 23);
            this.btnUltimo.TabIndex = 20;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(608, 269);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.txtCodVeiculo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gbbMarca);
            this.Controls.Add(this.lblNomeVeiculo);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.gbbTipo);
            this.Controls.Add(this.lblCodVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veiculos";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.gbbTipo.ResumeLayout(false);
            this.gbbMarca.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodVeiculo;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label lblCodVeiculo;
        private System.Windows.Forms.Label lblNomeVeiculo;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.GroupBox gbbTipo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbbMarca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
    }
}