namespace CrudEMnet.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    // Ex de TOCC8 feito por Gustavo Camargo e Pedro Lemos 

    [Table("produto")]
    public class Produto
    {
        [Key] // marca como chave primária
        [Column("codigo")] 
        public int Codigo { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("datavalidade")]
        public DateTime DataValidade
        {
            get => _dataValidade;
            set => _dataValidade = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }
        private DateTime _dataValidade;

        [Column("preco")]
        public double Preco { get; set; }

        [Column("taxalucro")]
        public double TaxaLucro { get; set; }

        
        [NotMapped]
        public double PrecoFinal => Preco + (Preco * TaxaLucro / 100);

        [NotMapped]
        public int PrazoValidade => (DataValidade - DateTime.Now).Days;
    }

}
