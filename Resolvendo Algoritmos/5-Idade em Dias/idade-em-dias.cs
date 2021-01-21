using System;

class MinhaClasse {
  public static void Main (string[] args) {
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = idadeEmDias / 365; 
    var diasRestante = idadeEmDias % 365;
    var meses = diasRestante / 30;  
    var dias = diasRestante % 30; 

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}