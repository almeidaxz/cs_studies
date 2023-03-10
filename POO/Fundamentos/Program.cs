namespace POO
{
    class Program
    {
        static void Main()
        {
            //objeto de tipo valor
            //copia os dados da estrutura
            var costumer = new Costumer();
            costumer.Name = "Lucas";
            Console.WriteLine(costumer.Name);

            //objeto de tipo referência
            //isntancia a estrutura
            var newCostumer = new Costumer2();
            newCostumer.Name = "Lu";

            Console.WriteLine(newCostumer.Name);
        }

        //define uma estrutura de dados
        //de tipo valor -- armazena os dados
        struct Costumer
        {
            //propriedade
            public string Name;
        }

        //define uma estrutura de dados
        //de tipo referência -- armazena o endereço
        public class Costumer2
        {
            //propriedade
            public string Name;
        }
    }
}

//classes e sctrucs que criamos e que podemos instanciar
//são considerados tipos complexos
//é boa prática quebrar objetos grandes em objetos menores
//exp: quebrar classe maior que mantém a classe pessoa
//que tem um endereço em um sub objeto endereço