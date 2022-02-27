using SGD.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGD.Data.Model
{
    public class Produto : Base
    {
        [Key]
        public Guid Id { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categorias { get; set; }

        public int SubCategoriaId { get; set; }
        public SubCategoria SubCategorias { get; set; }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }
        public int AnoEdicao { get; set; }
        public int NumeroEdicao { get; set; }
        public int NumeroPagina { get; set; }
        public string Idioma { get; set; }

        public Formato Formato { get; set; }

        public int PaisId { get; set; }
        public Pais Paises { get; set; }
    }
}
