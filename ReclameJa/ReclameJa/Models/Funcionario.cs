using System;
using System.Collections.Generic;
using System.Text;

namespace ReclameJa.Models
{
    public class Funcionario :Base
    {
        public int IdFuncionario { get; set; }
        public int IdOrgaoPublico { get; set; }
        public virtual OrgaoPublico OrgaoPublico { get; set; }
        public int IdFuncao { get; set; }
        public string Matricula { get; set; }
    }
}
