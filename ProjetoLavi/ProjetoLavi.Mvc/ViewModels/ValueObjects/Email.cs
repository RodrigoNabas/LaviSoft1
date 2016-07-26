using System.ComponentModel.DataAnnotations;

namespace ProjetoLavi.Mvc.ViewModels.ValueObjects
{
    public class Email
    {
        [EmailAddress]
        [MaxLength(254)]
        public string Endereco { get; set; }
        
        public Email()
        {
            
        }
    }
}
