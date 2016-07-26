using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjetoLavi.Mvc.ViewModels.ValueObjects;

namespace ProjetoLavi.Mvc.ViewModels
{
    public class ClienteModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo cnpj")]
        public Cnpj Cnpj { get; set; }

        [DisplayName("E-mail")]
        public Email Email { get; set; }

        public List<Telefone> Telefones { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}
