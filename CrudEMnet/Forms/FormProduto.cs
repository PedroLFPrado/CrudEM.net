using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudEMnet.Data;
using Microsoft.Extensions.Configuration;

namespace CrudEMnet.Forms
{
    public partial class FormProduto : Form
    {
        private readonly IConfiguration configuration;
        public FormProduto()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
            InitializeComponent();
        }
        // Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext(configuration))
            {
                var produto = new Produto
                {
                    Descricao = txtDescricao.Text,
                    DataValidade = dtpValidade.Value,
                    Preco = double.Parse(txtPreco.Text),
                    TaxaLucro = double.Parse(txtTaxaLucro.Text)
                };

                db.Produtos.Add(produto);
                db.SaveChanges();
            }

            MessageBox.Show("Produto inserido com sucesso!");
            Listar();
        }

        // Alterar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um produto na tabela para alterar.");
                return;
            }

            try
            {
                using (var db = new AppDbContext(configuration))
                {
                    foreach (DataGridViewRow row in dgvProdutos.SelectedRows)
                    {
                        if (row.Cells["Codigo"].Value is int codigo)
                        {
                            var produto = db.Produtos.Find(codigo);
                            if (produto != null)
                            {
                                produto.Descricao = txtDescricao.Text;
                                produto.DataValidade = dtpValidade.Value;
                                produto.Preco = double.Parse(txtPreco.Text);
                                produto.TaxaLucro = double.Parse(txtTaxaLucro.Text);
                            }
                        }
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Produto(s) alterado(s) com sucesso!");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar: {ex.Message}");
            }
        }

        //Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um produto na tabela para excluir.");
                return;
            }

            try
            {
                using (var db = new AppDbContext(configuration))
                {
                    foreach (DataGridViewRow row in dgvProdutos.SelectedRows)
                    {
                        if (row.Cells["Codigo"].Value is int codigo)
                        {
                            var produto = db.Produtos.Find(codigo);
                            if (produto != null)
                            {
                                db.Produtos.Remove(produto);
                            }
                        }
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Produto(s) excluído(s) com sucesso!");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir: {ex.Message}");
            }
        }

        //Listar todos
        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            using (var db = new AppDbContext(configuration))
            {
                var lista = db.Produtos.ToList()
                  .Select(p => new
                  {
                      p.Codigo,
                      p.Descricao,
                      p.DataValidade,
                      p.Preco,
                      p.TaxaLucro,
                      PrecoFinal = p.PrecoFinal,
                      PrazoValidade = p.PrazoValidade
                  }).ToList();

                dgvProdutos.DataSource = lista;
            }
        }

        //Filtrar por descrição
        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            using (var db = new AppDbContext(configuration))
            {
                string termo = txtDescricao.Text;
                var lista = db.Produtos
                    .Where(p => p.Descricao.Contains(termo))
                    .ToList()
                    .Select(p => new
                    {
                        p.Codigo,
                        p.Descricao,
                        p.DataValidade,
                        PrecoFinal = p.PrecoFinal,
                        PrazoValidade = p.PrazoValidade
                    }).ToList();

                dgvProdutos.DataSource = lista;
            }
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            FGrafico f;
            f = new FGrafico();
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog(); //não perde o foco

        }

        // Duplo clique no DataGridView
        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtCodigo.Text = row.Cells["Codigo"].Value?.ToString() ?? "";
                txtDescricao.Text = row.Cells["Descricao"].Value?.ToString() ?? "";
                txtPreco.Text = row.Cells["Preco"].Value?.ToString() ?? "";
                txtTaxaLucro.Text = row.Cells["TaxaLucro"].Value?.ToString() ?? "";

                if (row.Cells["DataValidade"].Value != null &&
                    DateTime.TryParse(row.Cells["DataValidade"].Value.ToString(), out DateTime validade))
                {
                    dtpValidade.Value = validade;
                }
                else
                {
                    dtpValidade.Value = DateTime.Now;
                }
            }
        }


        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                return;

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Digite um código válido.");
                return;
            }

            using (var db = new AppDbContext(configuration))
            {
                var produto = db.Produtos.Find(codigo);
                if (produto != null)
                {
                    txtDescricao.Text = produto.Descricao;
                    dtpValidade.Value = produto.DataValidade;
                    txtPreco.Text = produto.Preco.ToString();
                    txtTaxaLucro.Text = produto.TaxaLucro.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                    txtDescricao.Clear();
                    txtPreco.Clear();
                    txtTaxaLucro.Clear();
                    dtpValidade.Value = DateTime.Now;
                }
            }
        }


        private void txtTaxaLucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}