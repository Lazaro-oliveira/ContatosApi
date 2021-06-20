using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContato.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatorio")]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatorio")]
        [CpfValidation(ErrorMessage = "Cpf invalido")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatorio")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A senha deve ter entre 4 e 10 caracteres")]
        [SenhaValidation(ErrorMessage = "Senha deve ter pelo menos uma letra maiuscula, um número e um simbolo.")]
        public string senha { get; set; }

        public string anexo { get; set; }


    }
}
