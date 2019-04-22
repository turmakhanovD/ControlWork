using System;
using System.IO;
using System.Linq;

namespace NomadApp
{
    public class MonthReporter
    {
        public void MakeArticlesReport(string fileName)
        {
            string path =  fileName + ".csv";
            FileInfo fi1 = new FileInfo(path);

            if (!fi1.Exists)
            {
                //Create a file to write to.
                using (StreamWriter sw = fi1.CreateText())
                using(var nomadContext = new NomadContext())
                {
                    sw.WriteLine("Articles: Id, Title, PublishedTime\n");
                    foreach(var item in nomadContext.Articles.ToList())
                    {
                        sw.WriteLine($"Articles: {item.Id}, {item.Title}, {item.PublishedTime}");      
                    }
                    sw.WriteLine("\nArticles: Id, ArticleId, UserId, Delivered\n");
                    foreach (var item in nomadContext.Deliveries.ToList())
                    {
                        sw.WriteLine($"Delivered: {item.Id}, {item.ArticleId}, {item.UserId}, {item.Delivered.ToString()}");
                    }
                    
                }
            }
            else
                Console.WriteLine("Такой файл уже существует!");

            Console.WriteLine("Все успешно создано!");
        }

        public void MakeUsersReport(string fileName)
        {
            string path = @"Z:\Nomad Reports" + @"\" + fileName + ".csv";
            FileInfo fi1 = new FileInfo(path);
            var sum = 0;

            if (!fi1.Exists)
            {
                //Create a file to write to.
                using (StreamWriter sw = fi1.CreateText())
                using (var nomadContext = new NomadContext())
                {
                    sw.WriteLine("Users: Id, Name, SubscriptionId\n");
                    foreach (var item in nomadContext.Users.ToList())
                    {
                        sw.WriteLine($"User: {item.Id}, {item.Name}, {item.SubscriptionId} ");
                        sum += nomadContext.SubscriptionTypes.Where(x => x.Id == item.SubscriptionId).FirstOrDefault().Price;
                    }
                    sw.WriteLine("\nSubscriptionId: Id, Name, Price\n");
                    foreach (var item in nomadContext.SubscriptionTypes.ToList())
                    {
                        sw.WriteLine($"SubscriptionId: {item.Id}, {item.SubType}, {item.Price}");
                    }

                    sw.WriteLine($"sum = {sum}");
                }
            }
            else
                Console.WriteLine("Такой файл уже существует!");

            Console.WriteLine("Все успешно создано!");
        }



    }
}
