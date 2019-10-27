namespace ReclameJa.Models
{
    public enum TipoTelefone
    {
        Residencial = 0,
        Particular = 1,
        Comercial = 2
    }
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public int DDD { get; set; }
        public string Numero { get; set; }
        public int UsuarioId { get; set; }
        public bool Padrao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
