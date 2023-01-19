using System.Globalization;

namespace POO
{
    class ClassesAbstratas
    {
        static void Main()
        {

            //classes inferiores que herdaram a abstrata 
            //podem ser instanciadas
            var novoPagamentoCartao = new PagamentoCartao();
            var novoPagamentoBoleto = new PagamentoBoleto();

            //a classe genérica (abstrata) não pode ser instanciada
            var novoPagamentoGenerico = new Pagamento();


        }

        //abstract é utilizado para classes basicas, genéricas demais
        //para serem utilizadas diretamente ou instanciadas,
        //que só devem ser utilizadas para herança de classes filhas
        //*as classes abstratas podem ter contratos com interfaces
        public abstract class Pagamento : IPagamento
        {

        }

        //classes inferiores e mais detalhadas herdam as abstratas 
        public class PagamentoCartao : Pagamento
        {

        }
        //classes inferiores e mais detalhadas herdam as abstratas 
        public class PagamentoBoleto : Pagamento
        {

        }


        public interface IPagamento
        {

        }
    }

}