using BuscandoIE.Models.Enuns;

namespace BuscandoIE.Models
{
    public class InscricaoEstadual
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public long CNPJ { get; set; }
        public int NroIE { get; set; }
        public string UF { get; set; } = string.Empty;
        public SituacaoEnum SituacaoIE { get; set; }
    }
}