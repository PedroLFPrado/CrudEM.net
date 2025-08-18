using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CrudEMnet.Data;
using Microsoft.Extensions.Configuration;

public partial class FormProduto : Form
{

    private readonly IConfiguration configuration;

    public FormProduto()
    {
        InitializeComponent();
    }


    // ✅ Inserir
    private void btnInserir_Click(object sender, EventArgs e)
    {
        using (var db = new AppDbContext(configuration))
        {
            var produto = new Produto
            {
                Descricao = txtDescricao.Text,
                DataValidade = dtpValidade.Value,
                Preco = double.Parse(varPreco.Text),
                TaxaLucro = double.Parse(varTaxaLucro.Text)
            };

            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        MessageBox.Show("Produto inserido com sucesso!");
        Listar();
    }

    // ✅ Alterar
    private void btnAlterar_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtCodigo.Text, out int codigo))
        {
            using (var db = new AppDbContext(configuration))
            {
                var produto = db.Produtos.Find(codigo);
                if (produto != null)
                {
                    produto.Descricao = txtDescricao.Text;
                    produto.DataValidade = dtpValidade.Value;
                    produto.Preco = double.Parse(txtPreco.Text);
                    produto.TaxaLucro = double.Parse(txtTaxaLucro.Text);

                    db.SaveChanges();
                    MessageBox.Show("Produto alterado com sucesso!");
                    Listar();
                }
            }
        }
    }

    // ✅ Excluir
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtCodigo.Text, out int codigo))
        {
            using (var db = new AppDbContext(configuration))
            {
                var produto = db.Produtos.Find(codigo);
                if (produto != null)
                {
                    db.Produtos.Remove(produto);
                    db.SaveChanges();
                    MessageBox.Show("Produto excluído com sucesso!");
                    Listar();
                }
            }
        }
    }

    // ✅ Listar todos
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
                    PrecoFinal = p.PrecoFinal,
                    PrazoValidade = p.PrazoValidade
                }).ToList();

            dgvProdutos.DataSource = lista;
        }
    }

    // ✅ Buscar pelo código (evento Leave)
    private void txtCodigo_Leave(object sender, EventArgs e)
    {
        if (int.TryParse(txtCodigo.Text, out int codigo))
        {
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
            }
        }
    }

    // ✅ Filtrar por descrição (KeyUp)
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


    // ✅ Duplo clique no DataGridView
    private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
            txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
            dtpValidade.Value = Convert.ToDateTime(row.Cells["DataValidade"].Value);
            txtPreco.Text = row.Cells["PrecoFinal"].Value.ToString();
        }
    }

}