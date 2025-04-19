using System;
using Enums.Entities;
using Enums.Entities.Enum;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myObj = new Order
            {
                Id = 1002,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(myObj);

            int n1 = (int)OrderStatus.Delivered;
            Console.WriteLine("\n" + n1);

            string s1 = OrderStatus.Delivered.ToString();
            Console.WriteLine("\n" + s1);

            OrderStatus os1 = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("\n" + os1);
        }
    }
}