using System.Globalization;

namespace Moedas
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            decimal valor = 10.25m;

            Console.WriteLine(
                valor.ToString(
                    CultureInfo.CreateSpecificCulture("en-US"))
                    );
            //generic
            Console.WriteLine(
                valor.ToString("G",
                    CultureInfo.CreateSpecificCulture("en-US"))
                    );
            //currency
            Console.WriteLine(
                valor.ToString("C",
                    CultureInfo.CreateSpecificCulture("en-US"))
                    );
            //float better precision
            Console.WriteLine(
                valor.ToString("F",
                    CultureInfo.CreateSpecificCulture("en-US"))
                    );
            //number without currency sign
            Console.WriteLine(
                valor.ToString("N",
                    CultureInfo.CreateSpecificCulture("en-US"))
                    );
            //percentage
            Console.WriteLine(
                valor.ToString("N",
                    CultureInfo.CreateSpecificCulture("en-US"))
                    );
            //reduzido
            string.Format("{0:C}", valor);


            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}