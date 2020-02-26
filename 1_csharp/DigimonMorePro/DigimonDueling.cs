using System;

namespace DigimonMorePro
{
  public class DigimonDueling
  {
    static void Main(string[] args)
    {
      DigimonArena arena = new DigimonArena("Fire Arena");
      Digimon a = new Digimon("Fire");
      Digimon b = new Digimon("Ice");
      arena.Fight(a, b);
    }
  }
}
