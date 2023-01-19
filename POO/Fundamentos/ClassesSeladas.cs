using System.Globalization;

namespace POO
{
    class ClassesSeladas
    {
        static void Main()
        {

        }

        //sela a classe para que não possa ser herdada e extendida
        public sealed class Pagamento
        {


        }

        //erro ao herdar pois classe base é tipo sealed
        public class PagamentoCartão : Pagamento
        {

        }

    }
}