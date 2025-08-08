using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Inheritance
{
    namespace Assignment2.Inheritance
    {
        public class Animal
        {
            public virtual string MakeSound() => "Some generic sound";
        }

        public class Dog : Animal
        {
            public override string MakeSound() => "Bark";
        }

        public class Cat : Animal
        {
            public override string MakeSound() => "Meow";
        }
    }

}
