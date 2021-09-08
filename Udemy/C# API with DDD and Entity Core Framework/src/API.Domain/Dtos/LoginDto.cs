using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    class LoginDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(100, ErrorMessage = "O máximo para esse campo é de 100 caracteres.")]
        public string email { get; set; }
    }
}
