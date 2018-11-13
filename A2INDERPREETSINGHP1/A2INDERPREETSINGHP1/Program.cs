using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2INDERPREETSINGHP1
{
    class Program
    {
        static int fees;
        static void Main(string[] args)
        {


            {
                Console.WriteLine("Type yes for international student and no for canadian student");
                string C = Console.ReadLine();
                Console.WriteLine("Enter your age");
                string age = Console.ReadLine();
                int a = int.Parse(age);

                if (C == "yes" && a <= 18)
                {
                    Console.WriteLine("please pay the following amount");
                    fees = 300 + 39;
                    Console.WriteLine("Total fees = " + fees);
                }
                if (C == "Y" && a > 18 && a < 50)
                {
                    Console.WriteLine("please pay the following amount");
                    fees = 500 + 65;
                    Console.WriteLine("Total fees = " + fees);
                }
                if (C == "Y" && a > 50)
                {
                    Console.WriteLine("please pay the following amount");
                    fees = 400 + 52;
                    Console.WriteLine("Total fees = " + fees);
                }
                else if (C == "N" && a <= 18)
                {
                    Console.WriteLine("please pay the following amount");
                    fees = 300 + 100 + 39;
                    Console.WriteLine("Total fees = " + fees);
                }
                else if (C == "N" && a > 18 && a < 50)
                {
                    Console.WriteLine("please pay the following amount");
                    fees = 500 + 100 + 65;
                    Console.WriteLine("Total fees = " + fees);
                }
                if (C == "Y" && a > 50)
                {
                    Console.WriteLine("please pay the following amount");
                    fees = 400 + 100 + 52;
                    Console.WriteLine("Total fees = " + fees);
                }
                Console.WriteLine("enter month of registration");
                Console.WriteLine("1.FALL months = SEPT , OCT , NOV , DEC");
                Console.WriteLine("2.WINTER months = JAN , FEB , MARCH , APRIL");
                Console.WriteLine("3.SUMMER months = MAY , JUNE , JULY , AUG");
                string z = Console.ReadLine();
                int p = int.Parse(z);
                double mfees;
                switch (p)
                {
                    case 1:
                        mfees = 250 + 32.5;
                        Console.WriteLine("smester registration amount $" + mfees);
                        double Final = fees + mfees;
                        Console.WriteLine("sum amount" + Final);
                        break;
                    case 2:
                        mfees = 220 + 28.6;
                        Console.WriteLine("smester registration amount $" + mfees);
                        Final = fees + mfees;
                        Console.WriteLine("sum amount" + Final);
                        break;
                    case 3:
                        mfees = 150 + 19.5;
                        Console.WriteLine("smester registration amount $" + mfees);
                        Final = fees + mfees;
                        Console.WriteLine("sum amount" + Final);
                        break;
                    default:
                        Console.WriteLine("select from the given options");
                        break;
                }
            }
        }
    }
}