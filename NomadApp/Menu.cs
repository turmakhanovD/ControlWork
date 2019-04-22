using System;

namespace NomadApp
{
    public class Menu
    {
        public void StartMenu()
        {
            UserRegistrator newUser = new UserRegistrator();
            MonthReporter monthReporter = new MonthReporter();

            Console.WriteLine("Nomad.com");
            Console.WriteLine("Choose action:\n1.Registrate new user\n2.Get articles report\n3.Get finance report");
            int choose = 0;

            while (!int.TryParse(Console.ReadLine(), out choose))
            {
                Console.WriteLine("Write index of action (like 1.)");
            }

            switch (choose)
            {
                default:
                    Console.WriteLine($"We havent got action by index {choose}");
                    break;
                case 1:
                    newUser.Registrate();
                    break;
                case 2:
                    monthReporter.MakeArticlesReport("ArticleReport");
                    break;
                case 3:
                    monthReporter.MakeUsersReport("UserReport");
                    break;
            }

        }
    }
}
