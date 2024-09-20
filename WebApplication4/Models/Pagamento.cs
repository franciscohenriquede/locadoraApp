using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocacaowebAplication.Models
{

    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Pagamento { get; set; }

        public int ID_Locacao { get; set; } // Chave estrangeira
        public DateTime DataPagamento { get; set; }
        public float ValorPago { get; set; }
        public string FormaPagamento { get; set; } // ex: cartão de crédito, débito, dinheiro
    }
}