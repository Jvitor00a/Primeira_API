using System.ComponentModel.DataAnnotations;

namespace Primeira_API.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obritgatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obritgatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preco deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obritgatório")]
        public int QuantidadeEstoque {  get; set; }

        [Required(ErrorMessage = "O campo {0} é obritgatório")]
        public string? Descricao { get; set; }
    }
}
