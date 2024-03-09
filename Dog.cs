using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_sound.problem
{
    internal class Dog: Animal
    {
        public Dog(string type)
            : base(type) { }

        public override string MakesSound()
        {
            return "woof woof";
        }
    }
}
