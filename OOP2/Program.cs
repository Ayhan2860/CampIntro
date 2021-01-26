using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.FirstName = "Ayhan";
            customer1.LastName = "Kahraman";
            customer1.CustomerNumber = 346028;
            customer1.TcNumber = "8282128223";


            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = 286028;
            customer2.CompanyName = "Kodlama.io Student";
            customer2.TaxNumber = "602860";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
