using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaFinal.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Column("CategoriaId")]
        [Display(Name = "Código da Categoria")]
        public int Id { get; set; }

        [Column("CategoriaLivro")]
        [Display(Name = "Categoria do Livro")]
        public string CategoriaLivro { get; set; } = string.Empty;
    }
}

