namespace ProjetoLavi.Dominio.Entities.Receitas
{
    public class ReceitaItem : EntityBase
    {
        public int ReceitaItemId { get; set; }

        public const int ProcessoMaxLength = 30;
        public string Processo { get; set; }

        public string Grupo { get; set; }

        public string TipoProcesso { get; set; }

        public string Descricao { get; set; }

        public int OrdemItem { get; set; }

        public string ImagePath { get; set; }

        public bool EhInicio { get; set; }

        public bool EhFinal { get; set; }

        public int ReceitaId { get; set; }

        public ReceitaItem() { }
    }
}