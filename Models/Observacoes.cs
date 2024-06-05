using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoProjetoFinal1.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código")]
        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição da Observação")]
        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local da Observação")]
        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Data da Observação")]
        public DateTime ObservacoesData { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("PessoaId")]
        [Display(Name = "Pessoa")]
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}
