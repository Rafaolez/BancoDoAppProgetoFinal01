using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoProjetoFinal1.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código")]
        public int UsuarioId { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do Usuario")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioTelefone")]
        [Display(Name = "Telefone do Usuario")]
        public string UsuarioTelefone { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuario")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuario")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
