using System;
using ProjetoLavi.Dominio.Helpers;

namespace ProjetoLavi.Dominio.ValueObjects
{
    public class Cnpj
    {
        public const int CnpjMaxLength = 11;
        public long CodCnpj { get; set; }
        
        public Cnpj(){}

        public Cnpj(string cnpj)
        {

            Guard.ForNullOrEmptyDefaultMessage("CNPJ", cnpj);
            cnpj = StringHelper.GetNumeros(cnpj);
            Guard.StringLength("CNPJ", CnpjMaxLength, cnpj);
            try
            {
                CodCnpj = Convert.ToInt64(cnpj);
            }
            catch (Exception)
            {
                throw new Exception("Cnpj inválido: " + cnpj);
            }
        }
    }
}
