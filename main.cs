using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Informe um número: ");
    int n = int.Parse(Console.ReadLine());

    int r = dobro(n);
    Console.WriteLine("O dobro é: " + r);
    
  }

  public static int dobro (int numero){
    int d= numero *2;
    return d;
  }
}