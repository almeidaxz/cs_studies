using System.Globalization;

namespace POO
{
    class UsingDispose
    {
        static void Main()
        {
            //instancia criada e ctor chamado
            var novoPagamento = new Pagamento();
            //instancia finalizada e dispose chamado manualmente
            novoPagamento.Dispose();

            //JEITO CORRETO * BOA PRÁTICA
            //instancia é criada e ctor chamado no início do using
            using (var novoPagamento2 = new Pagamento())
            {
                Console.WriteLine("Esta será a etapa intermediária");
            }
            //instancia será encerrada e dispose será chamado

        }


        public class Pagamento : IDisposable
        {
            //o método construtor é chamado ao instanciar classe
            //"new" Classe();
            public Pagamento()
            {
                Console.WriteLine("Construtor é chamado ao instanciar");
            }

            //o método dispose é chamado manualmente para finalizar
            //a classe ou com o uso do "using(){}"
            //boa prática utilizar com o using
            public void Dispose()
            {
                Console.WriteLine("Destrutor é chamado ao final do using");
            }
        }

    }
}