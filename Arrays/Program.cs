namespace Arrays
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();

            // var meuArray = new int[5];
            // var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            // var meuArray = new int[] { 1, 2, 3, 4, 5 };
            int[] meuArray = { 1, 2, 3, 4, 5 };
            meuArray[0] = 11;
            meuArray[1] = 22;
            meuArray[3] = 33;

            var newArray = (int[])meuArray.Clone();
            newArray[0] = 1;

            // var meuArray = new Teste[1];
            // meuArray[0] = new Teste();
            var testes = new Teste[] { new Teste() { Id = 1 }, new Teste() { Id = 2 } };

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(newArray[0]);
            // Console.WriteLine(testes[0].Id);

            // foreach (var index in meuArray)
            //     Console.WriteLine(index);

            // foreach (var teste in testes)
            //     Console.WriteLine(teste.Id);
        }

        struct Teste
        {
            public int Id { get; set; }
        }
    }
}