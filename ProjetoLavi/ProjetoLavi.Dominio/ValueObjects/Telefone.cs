using ProjetoLavi.Dominio.Entities;
using ProjetoLavi.Dominio.Helpers;

namespace ProjetoLavi.Dominio.ValueObjects
{
    public class Telefone : EntityBase
    {
        //TODO : Em definição

        public int TelefoneId { get; set; }

        public const int NumeroMaxLength = 9;
        public string Numero { get; private set; }

        public const int DddMaxLength = 3;
        public string Ddd { get; private set; }

        protected Telefone(){}

        public Telefone(string ddd, string numero)
        {
            SetTelefone(numero);
            SetDdd(ddd);
        }

        private void SetTelefone(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                numero = "";
            else
                Guard.StringLength("Telefone", numero, NumeroMaxLength);
            Numero = numero;
        }

        private void SetDdd(string ddd)
        {
            if (string.IsNullOrEmpty(ddd))
                ddd = "";
            else
                Guard.StringLength("Ddd", ddd, DddMaxLength);
            Ddd = ddd;
        }

        public string GetTelefoneCompleto()
        {
            return Ddd + Numero;
        }
    }
}
