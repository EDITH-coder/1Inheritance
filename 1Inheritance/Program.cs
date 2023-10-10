using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakeChicken();
            chef1.MakesPasta();
            chef1.MakeSpecialDish();

            Console.ReadLine();

        }
    }
    internal class ItalianChef : Chef
    { 
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef make ItalianSpecial");
        }
        //this class inherit from superclass, Extends by making new functions and also ovverides some superclass functions
    }
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes a chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes special dish");
        }
    }
}
