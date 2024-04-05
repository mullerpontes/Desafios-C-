  using System;

  class Program {
    public static void Main (string[] args) {
      double [] valor = new double[10]; 

    for(int i=0; i<10; i++){

      Console.Write("Digite o "+(i+1)+"° valor: ");
      valor[i] = float.Parse(Console.ReadLine());

      if (valor[i] > 0){
        valor[i] = valor[i];
      }
      else{
        valor[i] = 1;
      }

        }

      for(int i=0; i<10; i++){
        Console.WriteLine("X["+i+"] = "+valor[i]);
      }
  }
  }