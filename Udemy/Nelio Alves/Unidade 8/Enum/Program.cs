using Enum.Entities;
using Enum.Entities.Enums;
using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order firstOrder = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(firstOrder);
            Console.WriteLine(firstOrder.Status.ToString());
            OrderStatus numAsStatus = System.Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(numAsStatus);
        }

    }
}

