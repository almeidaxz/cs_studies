namespace EditorHTML
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DesenharTela(12, 30);
            EscreverOpcoes();

            short opcao = short.Parse(Console.ReadLine());

            ManusearEscolha(opcao);
        }

        public static void DesenharTela(short linhas, short cols)
        {
            ConstuirLinhas(cols);

            for (int row = 0; row < linhas; row++)
            {
                Console.Write("|");
                for (int col = 0; col < cols; col++)
                    Console.Write(" ");
                Console.WriteLine("|");
            }

            ConstuirLinhas(cols);
            Console.WriteLine("\n");
        }

        public static void ConstuirLinhas(short cols)
        {
            Console.Write("+");
            for (int col = 0; col < cols; col++)
                Console.Write("=");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void EscreverOpcoes()
        {
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Editor HTML");
            Console.WriteLine("================================");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Selecione uma opção:");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(5, 12);
            Console.Write("Opção: ");
            Console.SetCursorPosition(12, 12);
        }

        public static void ManusearEscolha(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Mostar(); break;
                case 2: Console.WriteLine("Editar"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Mostrar(); break;
            }
        }
    }
}