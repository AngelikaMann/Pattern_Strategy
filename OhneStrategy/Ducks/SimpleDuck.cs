using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhneStrategy.Ducks
{
    public class SimpleDuck: DuckBase, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Hi, I'm a simple duck."); ;
        }
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");

        }
        public virtual void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
