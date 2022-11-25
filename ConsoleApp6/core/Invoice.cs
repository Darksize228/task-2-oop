using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.core
{
	internal class Invoice
	{   

		
		
        public Invoice(int account, int customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, int customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            Article = article;
            Quantity = quantity;
        }

        private int account;

		public  int Account
		{
			get { return account; }
			set { account = value; }
		}

		private int customer;

		public int Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		private string provider;

		public string Provider
		{ 
            get { return provider; }
			set { provider = value; }
		}

		private string article;

		public string Article
        {
			get { return article; }
			set { article = value; }
		}
		private int quantity;

		

		public int Quantity
        {
			get { return quantity; }
			set { quantity = value; }
		}

         public void Dns()
		{
			double nds = 0.2;

            double result = account * nds;
			Console.WriteLine(result);
		}
		 
		public void Vaib()
		{
			string c = "notnds";
			string b = "nds";
			 Console.WriteLine("Напишите цену с налогом или без ");
            Console.WriteLine("notnds");
            Console.WriteLine("nds");
            string v = Console.ReadLine();
			if (v==b)
			{
				Dns();

            }
			if (v==c)
			{
				Console.WriteLine(account);
			}
		}
    }
}
