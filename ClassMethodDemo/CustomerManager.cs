using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("The customer was added: " + customer.CustomerName + " " + customer.CustomerSurname);

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("The customer was deleted: " + customer.CustomerName + " " + customer.CustomerSurname);
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname);

            }
        }
    }
}
