namespace ProjetoLavi.Dominio.ValueObjects
{
    public class Ip
    {
        public string Endereco { get; private set; }

        protected Ip() { }
        public Ip(string enderecoIp)
        {
            SetEnderecoIp(enderecoIp);
        }

        private void SetEnderecoIp(string enderecoIp)
        {
            //TODO : Validações de um IP com Expressão regular na classe guard

            Endereco = enderecoIp;
        }
    }
}

    
