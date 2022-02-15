using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje_ProgramskiJezik
{
    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }

    }

    class Proceduralni : ProgramskiJezik
    {
        public Proceduralni(double postotak)
        {
            Postotak = postotak;
        }
    }
    class Objektni : ProgramskiJezik
    {
        public Objektni(double postotak) {
            Postotak = postotak;

        }

    }
    class Funkcionalni:ProgramskiJezik 
    {
        public Funkcionalni( double postotak) {
            Postotak = postotak;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite vrijednost postotaka za Proceduralni: ");
            Proceduralni x = new Proceduralni(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Upišite vrijednost postotaka za Objektni: ");
            Objektni y= new Objektni(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Upišite vrijednost postotaka za Funkcionalni: ");
            Funkcionalni z= new Funkcionalni(Convert.ToInt32(Console.ReadLine()));

            double zbroj = x.Postotak + y.Postotak + z.Postotak;

            if (zbroj == 100) {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzastupljenija je proceduralna vrsta programskih jezika. ");
                }
                else if(y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzastupljenija je objektna vrsta programskih jezika. ");
                }
                else
                {
                    Console.WriteLine("Najzastupljenija je funlcionalna vrsta programskih jezika. ");
                }
            }
            else
            {
                Console.WriteLine("Pogrešan unos podataka!");
            }



            Console.ReadKey();
        }
    }
}
