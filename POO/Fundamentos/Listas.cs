using System.Globalization;

namespace POO
{
    class Listas
    {
        static void Main()
        {
            //existem vários tipos complexos de listas
            //com diferentes usos
            //cria uma lista de tipo pessoa que herda outros tipos
            //por isso, tem vários métodos de manipulação
            var pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(1));

            //cria uma lista enumerável do tipo pessoa
            //tem poucos métodos que podem ser utilizados, por isso
            //é um dos mais seguros
            IEnumerable<Pessoa> novasPessoas = new List<Pessoa>();

            //cria uma lista de coleções, muito usado no acesso
            //à dados e entity framework 
            ICollection<Pessoa> maisNovasPessoas = new List<Pessoa>();


            //MÉTODOS MAIS COMUNS *

            //adiciona um novo objeto à lista
            pessoas.Add(new Pessoa(1));
            pessoas.Add(new Pessoa(2));
            pessoas.Add(new Pessoa(3));

            //itera a lista (pode iterar qualquer tipo IEnumerable)
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Id);
            }

            //adiciona vários itens na lista de uma vez (um range)
            //o método .addrange espera uma lista
            var novaLista = new List<Pessoa>();
            novaLista.AddRange(pessoas);

            //** MÉTODOS DO NAMESPACE LINQ
            //WHERE recebe uma expressão e retorna uma lista filtrada
            var pessoa1 = pessoas.Where(prop => prop.Id == 1);

            //FIRST retorna apenas a primeira ocorrência
            var pessoa2 = pessoas.First(prop => prop.Id == 2);
            //**  

            //remove - remove um item da lista
            novaLista.Remove(pessoa2);

            //removeRange - remove um range, uma parte da lista
            //primeiro argumento o índice, segundo argumento a quantidade
            novaLista.RemoveRange(1, 1);

            //clear limpa a lista
            novaLista.Clear();

            //.First -- retorna exception caso não encontre
            //.FirstOrDefault -- retorna null caso não encontre
            //.Any -- retorna um booleano para a ocorrência da expressão
            //.Count -- conta quantos items tem na lista como ocorrência
            //.Skip -- pula a quantidade informada como argumento
            //.Take -- retorna somente a quantidade informada como argumento
            //Skip e Take são usados juntos para fazer paginação

            //.AsEnumerable() converte a lista para Enumerable
            //.ToList() converte a lista para List
            //.ToArray() converte a lista para Array
        }

        public class Pessoa
        {
            public int Id { get; set; }
            public Pessoa(int id)
            {
                Id = id;
            }
        }

    }

}