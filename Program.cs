using Balta.ContentContext;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var article = new List<Article>();
            article.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            article.Add(new Article("Artigo sobre C#", "c-sharp"));
            article.Add(new Article("Artigo sobre .NEt", "dotnet"));

            foreach (var item in article)
            {
                Console.WriteLine("--------------------------------Article________________________________");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Url);
                Console.WriteLine("--------------------------------Fim Article________________________________");

            }

            var courses = new List<Course>();
            var course = new Course("Fundamentos OOP", "fundamento-oop");
            var course1 = new Course("SQL Server", "fundamento-oop");
            var course2 = new Course("Angular", "fundamento-oop");

            courses.Add(course);
            courses.Add(course1);
            courses.Add(course2);

            var career = new Career("Especialista .Net", "especialisar-dotnet");
            var careerAzure = new Career(".Net e Azure", "especialisar-Azure");
            var careerAngular = new Career("Angular especialista", "especialisar-angular");

            var careerItem = new CarrerItem(1, "Comece por aqui", "bom para quem não tem experiência em programação", course);
            var careerItem1 = new CarrerItem(2, "Azure", "bom para quem não tem experiência em programação", course2);
            var careerItem2 = new CarrerItem(3, "Angular", "bom para quem não tem experiência em programação", course1);
            var careerItem3 = new CarrerItem(4, "teste", "bom para quem não tem experiência em programação", null);

            var careers = new List<Career>();
            career.Items.Add(careerItem);
            career.Items.Add(careerItem1);
            career.Items.Add(careerItem2);
            career.Items.Add(careerItem3);

            careers.Add(career);


            foreach (var item in careers)
            {
                
                Console.WriteLine($"Título item careers aqui: {item.Title}");

                foreach (var caree in item.Items)
                {
                    Console.WriteLine($"{caree.Ordem}, {caree.Title}, {caree.Course?.Url}");
                }
            }



        }
    }
}
