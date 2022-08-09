using POO.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP", "www.orientacaooop.teste.com"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();

            var courseOOP = new Course("Fundamentos OOP", "fundamentos.oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos.csharp");
            var courseDotnet = new Course("Fundamentos .Net", "fundamentos.dotnet");

            courses.Add(courseOOP);
            courses.Add(courseDotnet);
            courses.Add(courseCsharp);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista.dotnet");
            var careerItem3 = new CareerItem(3, "Aprenda .Net", "comece o seu curso por aqui", courseDotnet);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "comece o seu curso por aqui", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "comece o seu curso por aqui", null);

            careerDotnet.CareerItems.Add(careerItem3);
            careerDotnet.CareerItems.Add(careerItem2);
            careerDotnet.CareerItems.Add(careerItem);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.CareerItems.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Title} - {item.Course?.Level}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}
