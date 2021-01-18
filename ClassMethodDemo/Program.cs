using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "Bensu";
            customer1.CustomerSurname = "Derin";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Ayşe";
            customer2.CustomerSurname = "Güneş";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerName = "Burak";
            customer3.CustomerSurname = "Deniz";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("----------------");

            customerManager.Delete(customer1);
            Console.WriteLine("----------------");

            customerManager.List(customers);


        }
    }
}
