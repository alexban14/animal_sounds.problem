using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_sound.problem
{
    internal abstract class Animal
    {
        private string type;

        public Animal(string type)
        {
            this.type = type;
        }

        public string GetAnimalType()
        {
            return type;
        }

        public abstract string MakesSound();
    }
}
