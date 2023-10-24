using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaFinal.Models
{
    [Table("Livros")]
    public class Livros
    {
        [Column("LivrosId")]
        [Display(Name = "Código do Livro")]
        public int Id { get; set; }

        [Column("NomeLivros")]
        [Display(Name = "Nome")]
        public string NomeLivros { get; set; } = string.Empty;

        [Column("SinopseLivros")]
        [Display(Name = "Sinopse")]
        public string SinopseLivros { get; set; } = string.Empty;

        [Column("AutorLivros")]
        [Display(Name = "Autor(a)")]
        public string AutorLivros { get; set; } = string.Empty;

        [Column("AnoLivros")]
        [Display(Name = "Ano de Publicação")]
        public int AnoLivros { get; set; }


        [Column("PaginasLivros")]
        [Display(Name = "Número de Páginas")]
        public int PaginasLivros { get; set; }

        [ForeignKey("CategoriaId")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}

