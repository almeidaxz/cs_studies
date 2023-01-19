using System.Globalization;

namespace POO
{
    class Delegates
    {
        //métodos anônimos ou delegate
        static void Main()
        {
            //"instancia-se a classe.funçãoBase passando a função
            //anônima como parâmetro SEM PARÊNTESIS (sem executá-la)
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            //em seguida, basta chamar a instancia passando o
            //parâmetro que é esperado
            pagar(1200);

        }

        public class Pagamento
        {
            //ao delegar, não precisa da implementação, pois será
            //feita por outra
            //as funções devem ter a mesma assinatura: mesmo retorno
            //e mesmos parâmetros
            public delegate void Pagar(double valor);
        }

        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
    }

}