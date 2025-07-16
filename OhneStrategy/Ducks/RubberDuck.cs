using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhneStrategy.Ducks
{
    public class RubberDuck:DuckBase, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Hi, I'm an rubber duck."); ;
        }

        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");

        }

    }
}
