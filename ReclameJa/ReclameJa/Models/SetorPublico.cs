using System;
using System.Collections.Generic;
using System.Text;

namespace ReclameJa.Models
{
    public class SetorPublico
    {
        public int IdSetorPublico { get; set; }
        public int IdOrgaoPublico { get; set; }
        public virtual OrgaoPublico OrgaoPublico { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}
