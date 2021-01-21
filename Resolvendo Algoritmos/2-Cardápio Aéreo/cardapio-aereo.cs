using System;

namespace cardapioAereo
{
  public class Program
  {
    static void Main(string[] args)
    {
      string[] comidaDisponivel = Console.ReadLine().Split(" ");
      
      int Ca = int.Parse(comidaDisponivel[0]);
      int Ba = int.Parse(comidaDisponivel[1]);
      int Pa = int.Parse(comidaDisponivel[2]);
      
      string[] comidaSolicitada = Console.ReadLine().Split(" ");
      
      int Cr = int.Parse(comidaSolicitada[0]);
      int Br = int.Parse(comidaSolicitada[1]);
      int Pr = int.Parse(comidaSolicitada[2]);
      
      int CaEmFalta = 0;
      int BaEmFalta = 0;
      int PaEmFalta =0;
      
      if (Ca < Cr)
        CaEmFalta = Cr - Ca;
        
      if (Ba < Br)
        BaEmFalta = Br - Ba;
        
      if (Pa < Pr)
        PaEmFalta = Pr - Pa;
        
      int totalEmFalta = CaEmFalta + BaEmFalta + PaEmFalta;
      
      Console.Write(totalEmFalta);
    }
  }
}