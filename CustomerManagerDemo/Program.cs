using System;

namespace CustomerManagerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { CustomerID = 1, Name = "Daniel", Surname = "Moor", Adress = "New Zeland", BankAccount = 1205000503 };
            Customer customer2 = new Customer { CustomerID = 2, Name = "Anne", Surname = "Kaelin", Adress = "France", BankAccount = 221254538 };
            Customer customer3 = new Customer { CustomerID = 3, Name = "Peter", Surname = "Blanc", Adress = "Germany", BankAccount = 1334644864 };
            
            CustmerManager customerManager = new CustmerManager();
            customerManager.Add(customer1);
            customerManager.Show(customer2);
            customerManager.Delete(customer3);
        }
    }

    class CustmerManager
    {   
        public void Add(Customer customer) 
        {
            Console.WriteLine("new customer: " + customer.Name);
            Console.WriteLine(customer.BankAccount);
            Console.WriteLine("customer is created successfuly");
            Console.WriteLine("----------");
        }

        public void Show(Customer customer)
        {
            Console.WriteLine("customer props");
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Surname: " + customer.Surname);
            Console.WriteLine("Adress: " + customer.Adress);
            Console.WriteLine("Bank Account: " + customer.BankAccount);
            Console.WriteLine("----------");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("customer: " + customer.Name);
            Console.WriteLine(customer.BankAccount);
            Console.WriteLine("customer is deleted successfuly");
            Console.WriteLine("----------");
        }
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public int BankAccount { get; set; }
    }
}
