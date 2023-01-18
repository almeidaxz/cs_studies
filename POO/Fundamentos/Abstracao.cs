namespace POO
{
    class PaymentsA
    {
        static void Main()
        {

        }

        //Abstracao => esconder/privar os detalhes
        //que só são pertinentes à este objeto 
        class Pagamentos
        {

            //variáveis => propriedades
            DateTime Vencimento;

            //funções => métodos
            void Pagar()
            {
                ConsultarSaldo();
            }

            //método abstraído -- private (usado somente aqui)
            private void ConsultarSaldo()
            {

            }

        }

    }
}