using System.Globalization;

namespace POO
{
    class Generics
    {
        //generics é uma forma de deixar um método genérico o suficiente
        //para aceitar outros tipos
        static void Main()
        {
            //ao instanciar é necessário informar o tipo:
            // var context = new DataContext<Pessoa>();
            // var pessoa = new Pessoa();
            // context.Save(pessoa);

            //é possível instanciar com múltiplos tipos, desde que
            //haja sobrecarga de métodos
            // var context = new DataContext<Pessoa, Pagamento, Inscricao>();
            //no caso de interface, a instancia também deve passar a if
            var context = new DataContext<IPessoa, Pagamento, Inscricao>();
            var pessoa = new Pessoa();
            var pagamento = new Pagamento();
            var inscricao = new Inscricao();
            context.Save(pessoa);
            context.Save(pagamento);
            context.Save(inscricao);


        }

        //para tornar classe genérica basta abrir setas <> com o tipo
        //esperado entre <T>, geralmente usado T ou única letra
        public class DataContext<P, PA, I>
            //boas práticas definir os tipos de forma fixa, limitando o uso 
            // where P : Pessoa
            //é possível implementar também com interface
            where P : IPessoa
            where PA : Pagamento
            where I : Inscricao
        {
            public void Save(P tipo)
            {
                Console.WriteLine(tipo);
            }
            public void Save(PA tipo)
            {
                Console.WriteLine(tipo);
            }
            public void Save(I tipo)
            {
                Console.WriteLine(tipo);
            }
        }

        public interface IPessoa { }

        //no caso de instanciar com interface, a classe deve ter 
        //contrato com a interface do caso
        public class Pessoa : IPessoa { }
        public class Pagamento { }
        public class Inscricao { }

    }

}