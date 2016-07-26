using System;
using System.Collections.Generic;

namespace ProjetoLavi.Dominio.Entities.Processo
{
    // TODO : Esclarecer alguns pontos de Regras de negócio com Vieira
    public class Processo
    {
        public int ProcessoId { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<ItemProcesso> ItensProcesso { get; set; } 
        public DateTime? TempoDoProcesso { get; set; }
        public DateTime? TempoEstimado { get; set; }
        public DateTime DataDeExecucao { get; set; }
    }
}