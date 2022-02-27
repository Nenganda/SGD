using System;

namespace SGD.Data.Model
{
    public class Base
    {
        public bool AtivoEstado { get; set; }
        public bool DeleteEstado { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataModificacao { get; set; }
    }
}
