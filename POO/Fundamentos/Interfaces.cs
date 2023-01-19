using System.Globalization;

namespace POO
{
    class Interfaces
    {
        static void Main()
        {

        }

        public partial class Pagamento : IPagamento
        {
            public DateTime DataVencimento { get; set; }

            public void Pagar(double valor)
            {
                throw new NotImplementedException();
            }
        }

        //implementa como a classe deve ser -- o que a classe deve ter
        //não como fazer, mas o que precisa ser feito
        //quais props e quais métodos a classe deve ter
        public interface IPagamento
        {

            //cria um contrato sobre as props que precisa ter
            DateTime DataVencimento { get; set; }

            //cria um contrato sobre os métodos que precisa ter
            //quem faz a implementação é a classe, portanto não precisa
            //de chaves
            void Pagar(double valor);
        }
    }

}