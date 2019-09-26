using System;
using System.Collections.Generic;
using System.Text;

namespace ReclameJa.Models
{
    public class OrgaoPublico
    {
        public int IdOrgaoPublico { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Municipio { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
    }
}
