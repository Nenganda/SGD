using System.Collections.Generic;

namespace SGD.Data.Model
{
    public class SubCategoria : Base
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        // Categoria
        public int CategoriaId { get; set; }
        public Categoria Categorias { get; set; }

        //Relationships
        public List<Produto> Produtos { get; set; }
    }
}
