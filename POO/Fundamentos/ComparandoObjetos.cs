using System.Globalization;

namespace POO
{
    class ComparandoObjetos
    {
        static void Main()
        {
            var pessoaA = new Pessoa("Lucas");
            var pessoaB = new Pessoa("Lucas");

            //comparar objetos diretamente não funciona, pq a comparação
            //resulta em endereços diferentes na memória o que dá false
            Console.WriteLine(pessoaA == pessoaB);
            //resulta false

            //a comparação por alguma propriedade que seja única
            //serviria, mas é desencorajada caso a classe tenha
            //muitas propriedades
            Console.WriteLine(pessoaA.Id == pessoaB.Id);
            //resulta true

            //outra forma de comparar seria implementando a interface
            //IEquatable<T> -- método complexo que vem de base
            //comparação com IEquatable
            Console.WriteLine(pessoaA.Equals(pessoaB));
            //resulta true

        }

        //definir contrato da classe com IEquatable<T>
        //dar CTRL + . para chamar intellisense e gerar membros
        public class Pessoa : IEquatable<Pessoa>
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public Pessoa(string name)
            {
                Name = name;
            }

            //metodo que é gerado pelo intellisense
            //recebe um Tipo e retorna um booleano
            //esse método ficará disponível para chamada 
            bool IEquatable<Pessoa>.Equals(Pessoa? other)
            {
                //aqui é só implementar a comparação
                return Id == other.Id;
            }
        }


    }

}