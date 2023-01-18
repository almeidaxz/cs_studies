using System.Globalization;

namespace POO
{
    class Propriedades
    {
        static void Main()
        {
            var pagamento = new Pagamento();

            pagamento.DataPagamento = DateTime.Now;
        }

        struct Pagamento
        {
            //snipet prop - quando não precisa manipular o valor das props
            public DateTime DataVencimento { get; set; }

            //snipet propfull
            private DateTime dataPagamento;
            public DateTime DataPagamento
            {
                //deste modo é possível interagir com o método antes
                //de concluír o método
                get
                {
                    Console.WriteLine("Lendo o Valor");
                    return dataPagamento;
                }
                set //(Tipo nome) -- isto já é incluso na variável value
                {
                    //value recebe automaticamente tipo e valor
                    dataPagamento = value;
                }
            }

        }
    }
}