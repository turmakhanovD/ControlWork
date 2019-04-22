using System;
using System.Linq;

namespace NomadApp
{
    public class UserRegistrator
    {
        public void Registrate()
        {
            User user = new User();
            Console.Clear();
            var context = new NomadContext();
            Console.WriteLine("Введите свое имя (на латинице): ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите свой адрес: ");
            user.Address = Console.ReadLine();
            Console.WriteLine("Какую подписку хотите оформить? \n1.Годовую\n2.Двухгодовую\n3.Трехгодовую");
            var choose = 0;
            while(!int.TryParse(Console.ReadLine(),out choose))
            {
                Console.WriteLine("Введите корректное число!");
            }

            switch (choose)
            {
                case 1:
                    user.SubscriptionId = context.SubscriptionTypes.Where(x => x.Price == 14000).FirstOrDefault().Id;
                    break;
                case 2:

                    user.SubscriptionId = context.SubscriptionTypes.Where(x => x.Price == 25000).FirstOrDefault().Id;
                    break;
                case 3:
                    user.SubscriptionId = context.SubscriptionTypes.Where(x => x.Price == 40000).FirstOrDefault().Id;
                    break;
            }

            Console.WriteLine("Все прошло успешно!");

            context.Users.Add(user);
            context.SaveChanges();
            context.Dispose();
            
        }
    }
}
