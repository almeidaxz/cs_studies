//Separação de pastas por Contexto
using MaosNaMassa.ContentContext;//contexto de conteúdos da plataforma
using MaosNaMassa.SubscriptionContext;

namespace MaosNaMassa
{
    class Program
    {
        static void Main()
        {
            //var conteudo = new Content(); NÃO É POSSÍVEL INSTANCIAR

            // var course = new Course();
            // course.Level = ContentContext.Enums.EContentLevel.Advanced;

            // var career = new Career();
            // career.Items.Add(new CareerItem());
            // Console.WriteLine(career.TotalCourses);

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orienta-obj"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();

            var courseOOP = new Course("Fundamentos OOP", "fund-oop");
            var courseCS = new Course("Fundamentos C#", "fund-cs");
            var courseASPNET = new Course("Fundamentos ASP.NET", "fund-asp");

            courses.Add(courseOOP);
            courses.Add(courseCS);
            courses.Add(courseASPNET);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "career-dotnet");
            var careerItemOOP = new CareerItem(2, "Aprenda OOP", "É pra começar por aqui", courseOOP);
            var careerItemDNET = new CareerItem(3, "Aprenda .NET", "É pra começar por aqui", courseASPNET);
            var careerItemCS = new CareerItem(1, "Aprenda C#", "É pra começar por aqui", courseCS);
            careerDotnet.Items.Add(careerItemOOP);
            careerDotnet.Items.Add(careerItemDNET);
            careerDotnet.Items.Add(careerItemCS);
            careers.Add(careerDotnet);


            // foreach (var career in careers)
            // {
            //     Console.WriteLine(career.Title);
            //     foreach (var item in career.Items.OrderBy(c => c.Order))
            //     {
            //         Console.WriteLine(item.Course.Title);
            //         Console.WriteLine($"{item.Order} - {item.Title}");
            //     }
            // }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }
    }
}
