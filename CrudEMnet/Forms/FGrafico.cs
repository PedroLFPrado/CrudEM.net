using CrudEMnet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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
            mostrarGrafico();
        }

        public void mostrarGrafico()
        {
            AppDbContext contexto;

            try
            {
                contexto = new AppDbContext(configuration);
                var lista = contexto.Produtos.ToList();

                chart1.ChartAreas[0].AxisX.Title = "Prazo de Validade";
                chart1.ChartAreas[0].AxisY.Title = "Taxa de Lucro";
                chart1.Titles.Clear();
                chart1.Titles.Add("Lucro x Prazo de Validade");

                chart1.Series.Clear();
                var serie = new Series("Lucro x Prazo")
                {
                    ChartType = SeriesChartType.Point,
                    IsVisibleInLegend = true
                };

                foreach (var obj in lista)
                {
                    // Calcula PrazoValidade em dias
                    int prazoValidade = (int)(obj.DataValidade - DateTime.Now).TotalDays;
                    double taxaLucro = obj.TaxaLucro;

                    serie.Points.AddXY(prazoValidade, taxaLucro);
                }

                chart1.Series.Add(serie);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}