﻿
Console.WriteLine("Välkomen till Filur");

Tamagotchi filur = new Tamagotchi();

Console.WriteLine("Välj namn på din filur!");
filur.namn = Console.ReadLine();

Console.WriteLine($"{filur.namn} är ett fantastiskt namn");

while (filur.GetAlive() == true)
{
  Console.Clear();
  filur.PrintStats();
  Console.WriteLine("Vad ska filuren göra");
  Console.WriteLine($"1. Lär {filur.namn} ett nytt ord");
  Console.WriteLine($"2. Prata med {filur.namn}");
  Console.WriteLine($"3. Mata {filur.namn}");
  Console.WriteLine($"4. Gör inget");

  string Vad = Console.ReadLine();
  if (Vad == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    filur.Teach(word);
  }
  if (Vad == "2")
  {
    filur.Hi();
  }
  if (Vad == "3")
  {
    filur.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  filur.Tick();
  Console.WriteLine("Press Enter to continue");
  Console.ReadLine();
}

Console.WriteLine($"OH NO! {filur.namn} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();