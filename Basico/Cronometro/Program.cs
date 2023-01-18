namespace Cronometro
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

            Console.WriteLine("Quanto tempo deseja cronometrar?");
            Console.WriteLine("Insira o tipo ao final com \"s\" ou \"m\"");
            Console.WriteLine("Exp: 10s");
            Console.WriteLine("Exp2: 1m");
            Console.WriteLine("");
            Console.WriteLine("Ou digite 0 para sair.");

            string resposta = Console.ReadLine();

            if (resposta == "0")
                Environment.Exit(0);

            if (resposta == null || resposta == "")
            {
                Console.WriteLine("Tempo inválido!");
                Thread.Sleep(3000);
                Menu();
            }

            string tipo = resposta.Substring(resposta.Length - 1, 1);
            int tempo = int.Parse(resposta.Substring(0, resposta.Length - 1));

            if (tipo != "m" && tipo != "s")
            {
                Console.WriteLine("Tempo inválido!");
                Thread.Sleep(3000);
                Menu();
            }

            int multiplicador = tipo == "m" ? 60 : 1;

            Iniciar(tempo * multiplicador);
        }

        static void Iniciar(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();

                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Cronômetro finalizado.");
            Thread.Sleep(1000);

            Menu();
        }
    }
}