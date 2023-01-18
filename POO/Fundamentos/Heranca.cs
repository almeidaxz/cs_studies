namespace POO
{
    class PaymentsH
    {
        static void Main()
        {
            var novoPagamentoPix = new PagamentoPix();

            //da classe derivada
            Console.WriteLine(novoPagamentoPix.ChavePix);

            //herdado da classe base
            novoPagamentoPix.Pagar();
            Console.WriteLine(novoPagamentoPix.Vencimento);
        }

        //Herança => herdar propriedades, métodos e eventos
        //de classes superiores
        class Pagamentos
        {

            //variáveis => propriedades
            public DateTime Vencimento;

            //funções => métodos
            public void Pagar()
            {
                ConsultarSaldo();
            }

            //método abstraído -- private (usado somente aqui)
            private void ConsultarSaldo()
            {

            }

        }

        class PagamentoPix : Pagamentos
        {
            public string ChavePix;
        }

    }
}