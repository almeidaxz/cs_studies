namespace Excecoes
{
    public class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3 };

            Console.Clear();

            try
            {
                // for (int i = 0; i < 5; i++)
                // {
                //     Console.WriteLine(arr[i]);
                // }
                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não existe este índice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                // Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine(ex.Mensagem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Algo deu errado.");

            }


        }
        static void Cadastrar(string texto)
        {
            // if (string.IsNullOrEmpty(texto))
            //     throw new Exception("O texto não pode ser nulo ou vazio.");
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
                Mensagem = "Exceção costumizada";
            }

            public DateTime QuandoAconteceu { get; set; }
            public string Mensagem { get; set; }
        }
    }
}