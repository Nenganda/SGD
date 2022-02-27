using System.Collections.Generic;

namespace SGD.Data.Model
{
    public class Categoria : Base
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relationships
        public List<SubCategoria> SubCategorias { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
