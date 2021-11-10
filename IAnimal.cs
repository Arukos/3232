using System;
using System.Collections.Generic;
using System.Text;

namespace _0
{
    interface IAnimal
    {
        public string Name { get; }

        public double Age { get;  set; }

        void eat(Food food);

        void Die();

        void Poop();

        void Sleep();
    }
}
