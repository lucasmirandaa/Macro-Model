using System.ComponentModel.DataAnnotations;

namespace Macro_Model.Models
{
    public class Pessoa
    {
        [Key]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Obrigatório informar CPF.")]
        [MaxLength(11, ErrorMessage = "Somente números.")]
        public int Cpf {  get; set; }
        [Display(Name ="Nome")]
        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
        public int Nome { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório informar e-mail.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail válido.")]
        public string Email { get;
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Obrigatório informar uma senha.")]
        public string Senha { get; set; }
    }
}
