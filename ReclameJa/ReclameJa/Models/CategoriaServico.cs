using System;
using System.Collections.Generic;
using System.Text;

namespace ReclameJa.Models
{
    public class CategoriaServico
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public virtual OrgaoPublico OrgaoPublico { get; set; }
    }
}
