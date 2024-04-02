using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Macro_Model.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [Display(Name = "Códgio do produto")]
        public string Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Informações Nutricionais")]
        [Required(ErrorMessage = "Obrigatório")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Descreva qual o tipo de de produto e sua categoria nutricional.")]
        public string Nutricional { get; set; }

		[Display(Name = "Restrições alimentares ")]
		[Required(ErrorMessage = "Obrigatório")]
		[MaxLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
		public string Restricao { get; set; }

	}
}
