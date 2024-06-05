using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BancoProjetoFinal1.Models
{
    public class Pessoa
    {
        [Column("PessoaId")]
        [Display(Name = "Código")]
        public int PessoaId { get; set; }

        [Column("PessoaNome")]
        [Display(Name = "Nome da Pessoa")]
        public string PessoaNome { get; set; } = string.Empty;

        [Column("PessoaRoupa")]
        [Display(Name = "Roupa da Pessoa")]
        public string PessoaRoupa { get; set; } = string.Empty;

        [Column("PessoaCor")]
        [Display(Name = "Cor da Pessoa")]
        public string PessoaCor { get; set; } = string.Empty;

        [Column("PessoaSexo")]
        [Display(Name = "Sexo da Pessoa")]
        public string PessoaSexo { get; set; } = string.Empty;

        [Column("PessoaObservacao")]
        [Display(Name = "Observação da Pessoa")]
        public string PessoaObservacao { get; set; } = string.Empty;

        [Column("PessoaLocalDesaparecimento")]
        [Display(Name = "Local do Desaparecimento da Pessoa")]
        public string PessoaLocalDesaparecimento { get; set; } = string.Empty;

        [Column("PessoaFoto")]
        [Display(Name = "Foto da Pessoa")]
        public string PessoaFoto { get; set; } = string.Empty;

        [Column("PessoaDtDesaparecimento")]
        [Display(Name = "Data do Desaparecimento da Pessoa")]
        public DateTime PessoaDtDesaparecimento { get; set; }

        [Column("PessoaDtEncontro")]
        [Display(Name = "Data do Encontro da Pessoa")]
        public DateTime? PessoaDtEncontro { get; set; }

        [Column("PessoaStatus")]
        [Display(Name = "Status da Pessoa")]
        public byte PessoaStatus { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
