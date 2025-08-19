namespace CrudEMnet.Forms
{
    // Ex de TOCC8 feito por Gustavo Camargo e Pedro Lemos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 3);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 11;
            label1.Text = "Código:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 123);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 3);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 13;
            label3.Text = "Preço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 67);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 14;
            label4.Text = "Taxa Lucro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 67);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 15;
            label5.Text = "Validade:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(529, 41);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(100, 27);
            txtDescricao.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(268, 41);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(100, 27);
            txtPreco.TabIndex = 3;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // txtTaxaLucro
            // 
            txtTaxaLucro.Location = new Point(395, 41);
            txtTaxaLucro.Name = "txtTaxaLucro";
            txtTaxaLucro.PlaceholderText = "Taxa de Lucro";
            txtTaxaLucro.Size = new Size(100, 27);
            txtTaxaLucro.TabIndex = 4;
            txtTaxaLucro.TextChanged += txtTaxaLucro_TextChanged;
            // 
            // dtpValidade
            // 
            dtpValidade.Location = new Point(268, 104);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(200, 27);
            dtpValidade.TabIndex = 2;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeight = 29;
            dgvProdutos.Location = new Point(12, 18);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(240, 150);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
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
