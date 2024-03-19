﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_sound.problem
{
    internal class Cow: Animal
    {
        public Cow(string type)
            :base(type) { }

        public override string MakesSound()
        {
            return "moo moo";
        }
    }
}
