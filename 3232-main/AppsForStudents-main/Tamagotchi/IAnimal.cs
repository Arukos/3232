using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    interface IAnimal
    {
        public string Name { get; }

        public double Age { get;  set; }

        void eat();

        void Die(int case1234);

        void Poop();

        void Sleep();
    }
}
