using System.Windows.Forms.DataVisualization.Charting;
using CrudEMnet.Data;

namespace CrudEMnet.Forms
{
    public partial class FGrafico : Form
    {
        private readonly IConfiguration configuration;

        public FGrafico()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
            InitializeComponent();
            MostrarGrafico();
        }

        // O método precisa estar AQUI dentro da classe 👇
        private void MostrarGrafico()
        {
            try
            {
                using var contexto = new AppDbContext(configuration);
                var lista = contexto.Produtos.ToList();

                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisX.Title = "Produtos";
                chart1.ChartAreas[0].AxisY.Title = "Valores";
                chart1.Titles.Clear();
                chart1.Titles.Add("Lucro e Prazo de Validade por Produto");

                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                var serieLucro = new Series("Lucro (R$)")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true,
                    Color = System.Drawing.Color.Blue,
                    IsXValueIndexed = true
                };

                var seriePrazo = new Series("Prazo Validade (dias)")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true,
                    Color = System.Drawing.Color.Orange,
                    IsXValueIndexed = true
                };

                foreach (var produto in lista)
                {
                    int prazoDias = (int)(produto.DataValidade - DateTime.Now).TotalDays;
                    double lucroReais = produto.PrecoFinal;

                    serieLucro.Points.AddXY(produto.Descricao, lucroReais);

                    if (prazoDias < 0)
                        seriePrazo.Points.AddXY(produto.Descricao, prazoDias);
                    else
                        seriePrazo.Points.AddXY(produto.Descricao, 0);
                }

                chart1.Series.Add(serieLucro);
                chart1.Series.Add(seriePrazo);

                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

                chart1.Series["Lucro (R$)"]["PointWidth"] = "0.4";
                chart1.Series["Prazo Validade (dias)"]["PointWidth"] = "0.4";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar gráfico: " + ex.Message);
            }
        }
    }
}