using System;
using System.Collections.Generic;
using System.Text;

namespace ReclameJa.Models
{
    public class Solicitacao
    {
        public int IdSolicitacao { get; set; }
        public int IdUsuario { get; set; }
        public int IdSetorPublico { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Origem { get; set; }
        public bool Status { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataTramitacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public string Resposta { get; set; }
        public string MotivoCancelamento { get; set; }
        public DateTime DataCancelamento { get; set; }
        public bool Anonimo { get; set; }
    }
}
