
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Mostar()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("=============================");

            Iniciar();
        }
        public static void Iniciar()
        {
            var texto = new StringBuilder();

            do
            {
                texto.Append(Console.ReadLine());
                texto.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("=============================");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("1 - Sim \t 2 - Não (Os dados serão perdidos)");

            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    {
                        ManusearSalvar(texto.ToString());
                        break;
                    }
                case 2:
                    {
                        texto.Clear();
                        Menu.Mostrar();
                        break;
                    }
                default:
                    break;
            }
        }

        public static void ManusearSalvar(string texto)
        {
            Console.WriteLine("Em qual caminho deseja salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo salvo em {caminho} com sucesso!");
            Thread.Sleep(2000);
            Visualizador.Mostrar(texto);
        }
    }
}