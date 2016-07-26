
using ProjetoLavi.Dominio.Enums;
using ProjetoLavi.Dominio.ValueObjects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ProjetoLavi.Mvc.ViewModels
{
    public class MaquinaModel
    {
        [Key]
        public int MaquinaId { get; set; }


        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        public string Descricao { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Ip")]
        //[DisplayName("Ip")]
        //public Ip IpMaquina { get; set; }


        //public EnumTipoMaquina TipoMaquina { get; set; }
        //public EnumModeloMaquina ModeloMaquina { get; set; }

        public double Capacidade { get; set; }
    }
}