using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Tamagotchi
{
     abstract class Animal : IAnimal
     {
          private Timer starving;
          private Timer thristy;
          private Timer boring;
          private Timer dirty;

          private bool isstarting;
          private bool isstate;
          private bool isbooring;
          private bool isdirty;

          public string Name { get; }

          public double Age { get; set; }

          public void Die(int case1234)
          {
               switch (case1234) {
                    case 1:

                         break;
                    case 2:
                         break;
                    case 3:
                         break;
                    case 4:
                         break;
               }
          }

          public void eat()
          {
               Console.WriteLine("Выбери чем кормить:(номер)");
               Console.WriteLine("1 - рис");
               Console.WriteLine("2 - мясо");
               Console.WriteLine("3 - овощи");
               Console.WriteLine("4 - комбикорм");
               Console.ReadKey();
               throw new NotImplementedException();
               isstarting = false;
          }

          public void Poop()
          {
               throw new NotImplementedException();
          }

          public void Sleep()
          {
               throw new NotImplementedException();
          }

          /*private void KillAnimal(object? state)
          {
               Console.WriteLine(starving.ToString());
               Die();
          }*/
          private void StartStarving(object? o)
          {
               Console.WriteLine(starving.ToString());
               Console.WriteLine("Покормишь плз? 1 или 2 (да или нет)");
               string choise = Console.ReadLine();
               if(choise == "1")
               {
                    eat();
                    starving.Change(TimeSpan.FromSeconds(1000), Timeout.InfiniteTimeSpan);
               }
               Die(1);
          }
          private void Sufferfromdirt(object? o)
          {
               Console.WriteLine(dirty.ToString());
               Die(2);
          }
          private void getthristy(object? o)
          {
               Console.WriteLine(thristy.ToString());
               Die(3);
          }
          private void getboring(object? o)
          {
               Console.WriteLine(boring.ToString());
               Die(4);
          }
          public Animal(string name)
          {
               starving = new Timer(StartStarving, "вот вот умру, хочу есть", TimeSpan.FromSeconds(10), Timeout.InfiniteTimeSpan);

               thristy = new Timer(getthristy, "Умераю от жажды", TimeSpan.FromSeconds(1600), Timeout.InfiniteTimeSpan);
               //thristy.Change(TimeSpan.FromSeconds(16), Timeout.InfiniteTimeSpan);

               boring = new Timer(getboring, "Умераю от скуки", TimeSpan.FromSeconds(2000), Timeout.InfiniteTimeSpan);
               //boring.Change(TimeSpan.FromSeconds(20), Timeout.InfiniteTimeSpan);

               dirty = new Timer(Sufferfromdirt, "Умераю от поноса", TimeSpan.FromSeconds(2600), Timeout.InfiniteTimeSpan);
               //dirty.Change(TimeSpan.FromSeconds(26), Timeout.InfiniteTimeSpan);
               Name = name;
          }
     }
}
