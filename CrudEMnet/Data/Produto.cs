namespace CrudEMnet.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("produto")]
    public class Produto
    {
        [Key] // marca como chave primária
        [Column("codigo")] 
        public int Codigo { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("datavalidade")]
        public DateTime DataValidade { get; set; }

        [Column("preco")]
        public double Preco { get; set; }

        [Column("taxalucro")]
        public double TaxaLucro { get; set; }

        // Não mapeados (calculados em memória)
        [NotMapped]
        public double PrecoFinal => Preco + (Preco * TaxaLucro / 100);

        [NotMapped]
        public int PrazoValidade => (DataValidade - DateTime.Now).Days;
    }

}
