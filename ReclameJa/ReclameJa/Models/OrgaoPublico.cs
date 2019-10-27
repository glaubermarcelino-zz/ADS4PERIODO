using System.Collections.Generic;

namespace ReclameJa.Models
{
    public class OrgaoPublico
    {
        public int IdOrgaoPublico { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
