using System;

namespace Digimon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Digimon a = new Digimon("Rawr");
            Digimon b = new Digimon("Grrrr");
            Digimon c = new Digimon("This is stupidly easy");
            Fight(a, b);
            Fight(b, a);
            Fight(a, c);
            Fight(c, a);
            Fight(b, c);
            Fight(c, b);
        }

        public static void Fight(Digimon _one, Digimon _two){
          System.Console.WriteLine("Digimon {0} and {1} are fighting!", _one.name, _two.name);
        }
    }

    public class Digimon{
      public String name {get; set;}

      public Digimon(String _name){
        this.name = _name;
      }
    }
}
