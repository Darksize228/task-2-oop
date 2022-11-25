using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.core
{
    internal class Employee
    {
		public double Derector = 1000;
		double Rabotnik = 700;
		double Uborchik = 500;
		double a = 0;
		double b = 0;
	public	string f = "Д";


        public Employee(string name, string surname, string dolgnost)
        {
            Name = name;
            Surname = surname;
            Dolgnost = dolgnost;
        }
        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}
		private string dolgnost;

	

		public string Dolgnost
		{
			get { return dolgnost; }
			set { dolgnost = value; }
		}


		public void MathD()
		{
			a = (Derector * 13) / 100;
			b = (Derector - a);
			Console.WriteLine($"Оклад-{b}$");
            Console.WriteLine($"Налог-{a}$");
        }

        public void MathR()
        { 
            a = (Rabotnik * 13) / 100;
            b = (Rabotnik - a);
            Console.WriteLine($"Оклад-{b}$");
            Console.WriteLine($"Налог-{a}$");
        }

        public void MathU()
        {
            a = (Uborchik * 13) / 100;
            b = (Uborchik - a);
            Console.WriteLine($"Оклад-{b}$");
            Console.WriteLine($"Налог-{a}$");
        }

		public void Dolg()
		{
			string D = "Derector";
            string R = "Rabotnik";
            string U = "Uborshik";

            Console.WriteLine("Напишите должность");
            Console.WriteLine("Derector");
            Console.WriteLine("Rabotnik");
            Console.WriteLine("Uborshik");
            string c=Console.ReadLine();
            if (D ==c)
			{
				MathD();

            }
			if (R==c)
			{
                MathR();
            }
			if (U==c)
			{
                MathU();
            }
		}
    }
}
