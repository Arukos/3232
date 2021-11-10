using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _0
{
    internal class Animal : IAnimal
    {
        private Timer starting;
        private Timer state;
        private Timer booring;
        private Timer dirty;

        private bool isstarting;
        private bool isstate;
        private bool isbooring;
        private bool isdirty;

        public string Name { get; }

        public double Age{get; set;}

        public void Die()
        {
            throw new NotImplementedException();
        }

        public void eat(Food food )
        {
            throw new NotImplementedException();
        }

        public void Poop()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        private void KillAnimal(object? state)
        {
            Console.WriteLine(state.ToString());
            this.Die();
        }
        private void StartStaring()
        {

        }
        private void Sufferfromdirt()
        {

        }
        private void getthristy()
        {

        }
        public Animal(string name)
        {
            starting = new Timer(StartStaring, "Умер от поноса", TimeSpan.FromMinutes(3), Timeout.InfiniteTimeSpan());
            state = new Timer(getthristy, "Умер от поноса", TimeSpan.FromMinutes(3), Timeout.InfiniteTimeSpan());
            booring = new Timer(KillAnimal, "Умер от поноса", TimeSpan.FromMinutes(3), Timeout.InfiniteTimeSpan());
            dirty = new Timer(Sufferfromdirt, "Умер от поноса", TimeSpan.FromMinutes(3), Timeout.InfiniteTimeSpan());
            this.Name = name;
        }
    }
}
