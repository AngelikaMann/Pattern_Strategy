using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhneStrategy.Ducks
{
  public abstract class DuckBase
    {
        
        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

        public abstract void Display();
    }
}
