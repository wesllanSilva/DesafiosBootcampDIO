using System;

namespace HoraDaCorrida
{
  public class Program
  {
    static void Main(string[] args)
    {
      string[] line = Console.ReadLine().Split(" ");
      
      int A = int.Parse(line[0]);
      int N = int.Parse(line[1]);
      int totalPlacas = A * N;
      
      for (int i = 10; i <= 90; i += 10) 
      {
        double total = (double)totalPlacas / 100 * i;
        Console.Write(Math.Ceiling(total) + " ");
      }
    }
  }
  
}}