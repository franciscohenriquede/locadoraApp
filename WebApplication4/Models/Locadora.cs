using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocacaowebAplication.Models
{
    public class Locadora
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // Propriedade para o ID da locação (chave primária)
        public int ID_Locacao { get; set; }

            // Propriedade para o ID do cliente (chave estrangeira)
            public int ID_Cliente { get; set; }

            // Propriedade para o ID do veículo (chave estrangeira)
            public int ID_Veiculo { get; set; }

            // Propriedade para a data de início da locação
            public DateTime DataInicio { get; set; }

            // Propriedade para a data de fim da locação
            public DateTime DataFim { get; set; }

            // Propriedade para o valor total da locação
            public float ValorTotal { get; set; }

            // Propriedade para o status da locação
            public string Status { get; set; }
        }


    }



