namespace ReclameJa.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Municipio { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
