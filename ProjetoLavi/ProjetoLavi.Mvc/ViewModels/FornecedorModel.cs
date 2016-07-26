using ProjetoLavi.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLavi.Mvc.ViewModels
{
    public class FornecedorModel
    {

        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Fantasia")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Fantasia { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Preencha o campo cnpj")]
        public Cnpj Cnpj { get; set; }

        public bool Ativo { get; set; }


    }
}