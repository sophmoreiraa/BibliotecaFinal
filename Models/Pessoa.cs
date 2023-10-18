using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaFinal.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("Id_Pessoa")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string NomePessoa { get; set; } = string.Empty;

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPFPessoa { get; set; } = string.Empty;

        [Column("TEL")]
        [Display(Name = "TEL")]
        public string TELPessoa { get; set; } = string.Empty;

    }
}

