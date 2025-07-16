using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhneStrategy.Ducks
{
    internal class ExoticDuck:DuckBase, IQuackable,IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Hi, I'm an exotic duck."); ;
        }
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");

        }
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
