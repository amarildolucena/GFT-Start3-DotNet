using System;
using DesafioRPG.src.Entities;

namespace DesafioRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, 5);
            Ninja wedge = new Ninja("Wedge", 23, 5);
            WizardWhite jemica = new WizardWhite("Jemica", 23, 5);
            WizardBlack topapa = new WizardBlack("Topapa", 23, 5);
                        
            Console.WriteLine(arus.ToString());
            Console.WriteLine(wedge.ToString());
            Console.WriteLine(jemica.ToString());
            Console.WriteLine(topapa.ToString());
            

            Console.WriteLine(arus.Attack(5));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(jemica.Attack());
            Console.WriteLine(topapa.Attack());

        }
    }
}