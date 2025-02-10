using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SubscriptionContext;

namespace Balta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "c-sharp"));
            articles.Add(new Article("Artigo sobre .NEt", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine("--------------------------------Article________________________________");
                Console.WriteLine($"Article id: {article.Id}, Article Title: {article.Title}, Article URL {article.Url}");
            }

            var courses = new List<Course>();
            var course = new Course("Fundamentos da Programação Orientada a Objetos", "fundamentos-oop");
            var course1 = new Course("SQL Server", "banco-de-dados");
            var course2 = new Course("Angular", "front-end");

            courses.Add(course);
            courses.Add(course1);
            courses.Add(course2);

            var career = new Career("Especialista .Net", "especialisar-dotnet");
            var careerAzure = new Career(".Net e Azure", "azure-specialist");
            var careerAngular = new Career("Angular Avançado", "angular-avancado");

            var careerItem = new CarrerItem(1, "Comece por aqui", "bom para quem não tem experiência em programação", course);
            var careerItem1 = new CarrerItem(2, "Azure", "especialize em azure", course2);
            var careerItem2 = new CarrerItem(3, "Angular", "aprenda frontend", course1);
            var careerItem3 = new CarrerItem(4, "teste", "esse é um teste", null);

            var careers = new List<Career>();
            career.Items.Add(careerItem);
            career.Items.Add(careerItem1);
            career.Items.Add(careerItem2);
            career.Items.Add(careerItem3);

            careers.Add(career);


            foreach (var item in careers)
            {
                Console.WriteLine("--------------------------------Career starts here________________________________");

                Console.WriteLine($"Título item careers aqui: {item.Title}");

                foreach (var c in item.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{c?.Ordem} | {c?.Title} | {c?.Course?.Url} | {c?.Course?.Level} | {c?.Descrioption}");

                    foreach (var notification in c.Notifications)
                    {
                        Console.WriteLine($"Notification: {notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalsubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalsubscription);

        }
    }
}
