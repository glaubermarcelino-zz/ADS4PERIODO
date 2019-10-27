using System.Collections.Generic;

namespace ReclameJa.Models
{
    public class Cidadao : Base
    {
        public int IdCidadao { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
