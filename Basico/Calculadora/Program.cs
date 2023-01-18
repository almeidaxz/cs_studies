namespace Basics
{
    class Program
    {
        static void Main()
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Opção:");

            short escolhido = short.Parse(Console.ReadLine());

            switch (escolhido)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float val1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float val2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {val1 + val2}");


            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float val1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float val2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da subtração é: {val1 - val2}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float val1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float val2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da divisão é: {val1 / val2}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float val1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float val2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da multiplicação é: {val1 * val2}");

            Console.ReadKey();
            Menu();
        }
    }
}