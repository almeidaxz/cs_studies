namespace EditorTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual função deseja realizar?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;

            }
        }

        static void Abrir()
        {
            Console.Clear();

            Console.WriteLine("Qual o caminho do arquivo?");
            var caminho = Console.ReadLine();

            using (var file = new StreamReader(caminho))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("(Tecle ESC para sair)");
            Console.WriteLine("-----------------------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += " ";
                texto += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Em qual caminho deseja salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (var file = new StreamWriter(caminho))
            {
                file.Write(texto);
            }
            Console.WriteLine($"Arquivo salvo em {caminho} com sucesso!");
            Thread.Sleep(2000);

            Menu();
        }
    }
}