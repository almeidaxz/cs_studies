namespace EditorHTML
{
    public static class Visualizador
    {


        public static void Mostrar(string texto)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("=============================");

            Console.WriteLine(texto);

        }

        public static void Substituir()
        {

        }
    }

}