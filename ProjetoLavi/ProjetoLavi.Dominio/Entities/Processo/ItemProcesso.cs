using System;
// TODO : Definir regras de negócio
namespace ProjetoLavi.Dominio.Entities.Processo
{
    public class ItemProcesso
    {
        public int ItemProcessoId { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double? Dosagem { get; set; }
        public double? NivelDeAgua { get; set; }
        public double? Temperatura { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFinal { get; set; }
        public DateTime? TempoDoProcesso { get; set; }
        public DateTime? TempoEstimado { get; set; }
        public int ProcessoId { get; set; }
    }
}
