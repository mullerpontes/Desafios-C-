using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o número da sequência de  que deseja saber:");
    int n = Convert.ToInt32(Console.ReadLine());
    if(n < 1 || n > 45){
      Console.WriteLine("Por favor, digite um número entre 1 e 45.");
      return;
    }
    int a = 0, b = 1;
    Console.Write($"Os {n} primeiros números da sequência d são: ");
    if(n >= 1 )
    Console.Write(a+" ");
    if(n >= 2)
    Console.Write(b+" ");
    for(int i = 2; i < n; i++){
      int c = a + b;
      Console.Write(c+" ");
      a = b;
      b = c;
    }
    Console.WriteLine();
    
  }
}