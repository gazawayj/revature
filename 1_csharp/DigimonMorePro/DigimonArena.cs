using System;

namespace DigimonMorePro
{
  public class DigimonArena
  {    
    private String arenaName;
    private int myVar;
    
    private Digimon firstDigi;
    public Digimon FirstDigi
    {
        get { return firstDigi; }
        set { firstDigi = value; }
    }

    private Digimon secondDigi;
    public Digimon SecondDigi
    {
        get { return secondDigi; }
        set { secondDigi = value; }
    }
    

    public DigimonArena(String _name)
    {
      this.arenaName = _name;
    }
    public void Fight(Digimon a, Digimon b)
    {
      this.FirstDigi = a;
      this.SecondDigi = b;
      System.Console.WriteLine("Digimon {0} is fighting Digimon {1} in arena: {2}.", this.FirstDigi.name, this.SecondDigi.name, arenaName);
    }
  }
}