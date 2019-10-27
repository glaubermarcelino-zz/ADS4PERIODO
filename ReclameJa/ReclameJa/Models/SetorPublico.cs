namespace ReclameJa.Models
{
    public class SetorPublico
    {
        public int IdSetorPublico { get; set; }
        public int IdOrgaoPublico { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual CategoriaServico CategoriaServico { get; set; }
        public virtual OrgaoPublico OrgaoPublico { get; set; }

    }
}
