using System.Globalization;

namespace POO
{
    class ClassesEstaticas
    {
        static void Main()
        {

            Pagamento.DataVencimento = DateTime.Now;
        }

        //classes estáticas irão ocupar lugar na memória de imedito
        //portanto, não podem ser instanciadas
        public static class Pagamento
        {
            //uma classe estática tem props e métodos estáticos
            public static DateTime DataVencimento { get; set; }

            //o método construtor não acontecerá, pois não há instância
            // public Pagamento(Parameters)
            // {

            // }

        }
        //EXP prático
        //informações pequenas, fixas e que são usadas de forma
        //ampla por toda aplicação.
        public static class Configuracoes
        {
            public static string API_URL { get; set; }
        }

    }
}