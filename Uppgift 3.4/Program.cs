using System;
namespace Övning_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten?");
            string svar = Console.ReadLine();
            int mellanslagsindex = svar.IndexOf(" ");
            string minutersvar = svar[..mellanslagsindex];
            string sekundersvar = svar[(mellanslagsindex + 1)..];
            int minuter = int.Parse(minutersvar);
            int sekunder = int.Parse(sekundersvar);


            switch (minuter)
            {
                case 0:
                    Console.WriteLine("Din låt får inte visas");
                    break;
                
                case 1:
                    Console.WriteLine("Din låt får inte visas");
                    break;

                case 2:

                    if (sekunder >= 45 || sekunder <= 60)
                        {
                        Console.WriteLine("Din låt får visas");
                        }

                    else
                        {
                        Console.WriteLine("Din låt får ej visas");
                        }
                    break;

                case 3:
                    Console.WriteLine("Din låt får visas");
                    break;

                case 4:
                    if (sekunder <= 20 || sekunder <= 60)
                        {
                            Console.WriteLine("Din låt får visas");
                        }
                    else
                        {
                        Console.WriteLine("Din låt får ej visas");
                        }
                    break;
            }
            Console.ReadKey();
        }
    }
}