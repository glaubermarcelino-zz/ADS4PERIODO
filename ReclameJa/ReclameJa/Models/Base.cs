using System;
using System.Collections.Generic;
using System.Text;

namespace ReclameJa.Models
{
    public abstract class Base :Usuario
    {
        public string Foto { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Nacionalidade { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
    }
}
