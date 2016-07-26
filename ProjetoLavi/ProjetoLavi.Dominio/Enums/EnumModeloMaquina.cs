using System.ComponentModel.DataAnnotations;

namespace ProjetoLavi.Dominio.Enums
{
    public enum EnumModeloMaquina
    {
        [Display(Name = "Frontal 30Kg")]
        F30,
        [Display(Name = "Horizontal 30Kg")]
        H30,
        [Display(Name = "Frontal 50Kg")]
        F50,
        [Display(Name = "Horizontal 50Kg")]
        H50,
        [Display(Name = "Frontal 100Kg")]
        F100,
        [Display(Name = "Horizontal 100Kg")]
        H100,
        [Display(Name = "Frontal 200Kg")]
        F200,
        [Display(Name = "Horizontal 200Kg")]
        H200
    }
}
