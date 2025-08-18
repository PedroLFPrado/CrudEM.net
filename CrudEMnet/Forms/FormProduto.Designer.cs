namespace CrudEMnet.Forms
{
    partial class FormProduto
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
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            txtTaxaLucro = new TextBox();
            dtpValidade = new DateTimePicker();
            dgvProdutos = new DataGridView();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            btnGrafico = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(268, 21);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(268, 141);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 27);
            txtDescricao.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(420, 21);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 27);
            txtPreco.TabIndex = 3;
            // 
            // txtTaxaLucro
            // 
            txtTaxaLucro.Location = new Point(553, 85);
            txtTaxaLucro.Name = "txtTaxaLucro";
            txtTaxaLucro.Size = new Size(100, 27);
            txtTaxaLucro.TabIndex = 4;
            // 
            // dtpValidade
            // 
            dtpValidade.Location = new Point(268, 85);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(200, 27);
            dtpValidade.TabIndex = 2;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeight = 29;
            dgvProdutos.Location = new Point(0, 0);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(240, 150);
            dgvProdutos.TabIndex = 5;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(20, 200);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(420, 200);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(120, 200);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(220, 200);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnGrafico
            // 
            btnGrafico.Location = new Point(320, 200);
            btnGrafico.Name = "btnGrafico";
            btnGrafico.Size = new Size(75, 23);
            btnGrafico.TabIndex = 10;
            btnGrafico.Text = "Gráfico";
            btnGrafico.UseVisualStyleBackColor = true;
            btnGrafico.Click += btnGrafico_Click;
            // 
            // FormProduto
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(txtCodigo);
            Controls.Add(txtDescricao);
            Controls.Add(dtpValidade);
            Controls.Add(txtPreco);
            Controls.Add(txtTaxaLucro);
            Controls.Add(dgvProdutos);
            Controls.Add(btnInserir);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnGrafico);
            Name = "FormProduto";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxaLucro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }

       
}
