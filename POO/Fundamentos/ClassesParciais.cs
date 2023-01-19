using System.Globalization;

namespace POO
{
    class ClassesParciais
    {
        static void Main()
        {
            var novoPagamento = new Pagamento();

            //fazem parte da mesma instância
            novoPagamento.PagamentoA;
            novoPagamento.PagamentoB;
        }

        //permite que uma mesma classe seja dividida entre ARQUIVOS
        //que serão unidos em tempo de compilação e podem ser acessados
        //de uma outra classe ou lugar no código de forma conjunta

        //Exemplo não realista
        public partial class Pagamento
        {
            public string PagamentoA { get; set; }

        }
        public partial class Pagamento
        {
            public string PagamentoB { get; set; }

        }

    }
}