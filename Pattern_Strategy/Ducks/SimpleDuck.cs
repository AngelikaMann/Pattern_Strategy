using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Strategy.Fly;
using Pattern_Strategy.Qauck;


namespace Pattern_Strategy.Ducks
{
   public class SimpleDuck: DuckBase
    {
        public SimpleDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm an simple duck.");
        }

    }
}
