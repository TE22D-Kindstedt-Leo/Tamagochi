using System;
using System.Collections.Generic;

public class Tamagotchi
{
  private int hunger;
  private int boredom;
  private List<string> words = new List<string>() {"Knas"};
  private bool Health;
  public string namn;

  public Tamagotchi()
  {
    Health = true;
  }

  public void Feed()
  {
    if (hunger > 0)
    {
      Console.WriteLine($" [{namn}] blir matat och är inte lika hungrig");
      hunger -= new Random().Next(2,5);
      hunger = 0;
    }
    else if (hunger == 0)
    {
      hunger = 0;
      Console.WriteLine($"{namn} är redan mät");
    }
  }

  public void Hi()
  {
    int wordNum = Random.Shared.Next(words.Count);
    Console.WriteLine($" [{namn}] says: {words[wordNum]}");
    ReduceBoredom();
  }

  public void Teach(string word)
  {
    Console.WriteLine($" [{namn}] learns: {word}");
    words.Add(word);
    ReduceBoredom();
  }

  public void Tick()
  {
    hunger++;
    boredom++;
    if (hunger > 10 || boredom > 10)
    {
      Health = false;
    }
  }

  public void PrintStats()
  {
    Console.WriteLine($"Namn: {namn} || Mat: {hunger}/10 || Boredom: {boredom}/10 || Vocabulary: {words.Count} words");
  }

  public bool GetAlive()
  {
    return Health;
  }

  public void ReduceBoredom()
  {
    Console.WriteLine($" [{namn}] is now less bored!");

    boredom -= 2;
    if (boredom < 0)
    {
      boredom = 0;
    }
  }
}