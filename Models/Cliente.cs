using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_tela05.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeCliente { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression("^[0-9]{2}-([0-9]{8}|[0-9]{9})")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]

        [StringLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string Endereco { get; set; }
        
    }
}
