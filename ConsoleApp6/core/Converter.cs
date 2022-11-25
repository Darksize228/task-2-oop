using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.core
{
    public class Converter
    {

        public double itog1;
        public double itog2 = 0;
        double RB = 6;
        public Converter(double itog1, double btc, double eth, double bnb)
        {
            Btc = btc;
            Eth = eth;
            Bnb = bnb;
           
        }
        private double btc;

		public double Btc
		{
			get { return btc; }
			set { btc = value; }
		}
		private double eth;

		public double Eth
		{
			get { return eth; }
			set { eth = value; }
		}

		private double bnb;

		public double Bnb
		{
			get { return bnb; }
			set { bnb = value; }
		}

		public void  Convert1()
		{
			
			itog1 = RB * btc;
            itog2 = btc / RB;

            Console.WriteLine(itog1);
          


        }
        public void Convert2()
        {
            itog1 = RB * eth;
            itog2 = eth / RB;

            Console.WriteLine(itog1);

        }
        public void Convert3()
        {
            itog1 = RB * bnb;
            itog2 = bnb / RB;

            Console.WriteLine(itog1);


        }



    }
}
