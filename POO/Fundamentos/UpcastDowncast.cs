using System.Globalization;

namespace POO
{
    class UpcastDowncast
    {
        static void Main()
        {
            //upcast e downcast permite alterar o tipo da instancia
            //para o tipo mais alto (da clase base), ou o contrário
            //contanto que haja herança

            //instanciado da classe base -- upcast
            //é possível reinstanciar pois as classes que herdam possuem
            //todas as propriedades que a classe base possui (e até mais)
            var pessoa = new Pessoa();
            //é possível reinstanciar o objeto para as classes filhas
            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();

            //instanciando da classe filha -- downcast
            //é possível reinstanciar porem as propriedades que as
            //classes filhas tem serão perdidas
            var novaPessoaFisica = new PessoaFisica();
            //neste caso é necessário utilizar cast explícito
            novaPessoaFisica = (PessoaFisica)new Pessoa();

            //não é possível realizar o casting ou reinstanciar 
            //entre classes do mesmo nível
            var novaPessoaJuridica = new PessoaJuridica();
            novaPessoaJuridica = new PessoaFisica();
            novaPessoaJuridica = (PessoaJuridica)new PessoaFisica();

        }

        public class Pessoa
        {
            public string Name { get; set; }
        }

        public class PessoaFisica : Pessoa
        {
            public string CPF { get; set; }
        }

        public class PessoaJuridica : Pessoa
        {
            public string CNPJ { get; set; }
        }

    }

}