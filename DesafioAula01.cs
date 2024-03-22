using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a Velocidade Média");
        float velocidademedia = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tempo Gasto");
        float tempo = int.Parse(Console.ReadLine());
        float distancia = velocidademedia * tempo;
        Console.WriteLine("A distancia percorrida é de " + distancia);
        double litros = distancia / 12;
        litros = Math.Round(litros, 3);

        Console.WriteLine("Foi gasto na viagem" + litros + " litros de combustivel");
        eLine
  }
}