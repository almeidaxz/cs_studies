
using System.Globalization;

namespace Datas
{
    public static class Program
    {
        public static void Main()
        {
            // var data = new DateTime();
            //YYYY/MM/dd/hh/mm/ss
            var data = DateTime.Now;

            // var formatado = String.Format("{0:yyyy/MM/dd}", data);
            // var formatado = String.Format("{0:yy/MM/dd}", data);
            // var formatado = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            // var formatado = String.Format("{0:dd/MM/yyyy hh:mm:ss z}", data);
            // var formatado = String.Format("{0:t}", data);
            // var formatado = String.Format("{0:T}", data);
            // var formatado = String.Format("{0:d}", data);
            // var formatado = String.Format("{0:D}", data);
            // var formatado = String.Format("{0:f}", data);
            // var formatado = String.Format("{0:g}", data);
            // var formatado = String.Format("{0:u}", data);
            // var formatado = String.Format("{0:s}", data);
            var formatado = String.Format("{0:r}", data);
            // Console.WriteLine(formatado);
            Console.WriteLine(data.ToString("d"));

            Console.WriteLine(data.AddDays(-15));
            // Console.WriteLine(data.AddMonths(2));
            // Console.WriteLine(data.AddYears(2));

            Console.WriteLine(data.Date == DateTime.Now.Date);

            // var pt = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            // var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(data.ToString("d", de));

            var dateTime = DateTime.UtcNow;

            // Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            var timezoneAustralia =
             TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            var horaAustralia =
             TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);

            Console.WriteLine(timezoneAustralia);
            Console.WriteLine(horaAustralia);
        }
    }
}