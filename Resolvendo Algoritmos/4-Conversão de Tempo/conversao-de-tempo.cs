using System;

namespace conversaoDeTempo
{
  public class program
  {
    static void Main(string[] args)
    {
      var tempoEmSegundos = int.Parse(Console.ReadLine());
      var horas = tempoEmSegundos / (60 * 60);
      tempoEmSegundos = tempoEmSegundos % (60 * 60);
      var minutos = tempoEmSegundos / 60;
      var segundos = tempoEmSegundos % 60;
      
      Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
  }
}