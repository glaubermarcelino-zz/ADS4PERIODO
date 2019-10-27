using System.Collections.Generic;

namespace ReclameJa.Models
{
    public class Funcionario :Base
    {
        public int IdFuncionario { get; set; }
        public int IdOrgaoPublico { get; set; }
        public virtual OrgaoPublico OrgaoPublico { get; set; }
        public int IdFuncao { get; set; }
        public string Matricula { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
