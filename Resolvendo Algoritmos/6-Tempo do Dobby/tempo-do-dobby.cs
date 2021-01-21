using System;

namespace tempoDoDobby
{
  class program {
    public static void Main (string[] args)
    {
      var minutosQueFaltam = int.Parse(Console.ReadLine());
      
      string[] tokens = Console.ReadLine().Split(" ");
      
      int[] minutos = Array.ConvertAll<string, int>(tokens, int.Parse);
      
      int tempoDoBrinquedoA = minutos[0];
      int tempoDoBrinquedoB =minutos[1];
      int tempoDe2Brinquedos = tempoDoBrinquedoB + tempoDoBrinquedoA;
      
      if (tempoDe2Brinquedos <= minutosQueFaltam)
      {
        Console.WriteLine("Farei hoje!");
      }else
      {
        Console.WriteLine("Deixa para amanha!");
      }
    }
  }
}