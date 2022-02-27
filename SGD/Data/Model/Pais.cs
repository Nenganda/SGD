using System.Collections.Generic;

namespace SGD.Data.Model
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //Relationships
        public List<Produto> Produtos { get; set; }
    }
}
