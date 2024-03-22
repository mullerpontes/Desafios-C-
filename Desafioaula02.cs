using System;

class Program {
  public static void Main (string[] args) {
    double v1 = 4.00; 
    double v2 = 4.50;
    double v3 = 5.00;  
    double v4 = 2.00;
    double v5 = 1.50;
    Console.WriteLine("Menu de Itens" );
    Console.WriteLine("1 - Cachorro Quente - R$ 4.00");
    Console.WriteLine("2 - X-Salada - R$ 4.50");
    Console.WriteLine("3 - X-Bacon - R$ 5.00");
    Console.WriteLine("4 - Torrada Simples - R$ 2.00");
    Console.WriteLine("5 - Refrigerante - R$ 1.50");
    Console.WriteLine("Digite o código do item:" );
    
    int codigo = int.Parse(Console.ReadLine());
     if (codigo>5 ){
       Console.WriteLine("Código inválido");
      Console.WriteLine("Digite 1 para cachorro quente, 2 para hambúrguer, 3 para cheeseburguer, 4 para ref");
       codigo = int.Parse(Console.ReadLine());
       }
    Console.WriteLine("Digite a quantidade:" );
    int quantidade = int.Parse(Console.ReadLine());
    double total ;
    if (codigo == 1){
      total = v1 * quantidade;
      Console.WriteLine("O Valor total do Cachorro Quente é :R$ " + total );
    }
    else if (codigo == 2){
      total = v2 * quantidade;
      Console.WriteLine("O Valor total do X-Salada é :R$ " + total );  
    }
    else if (codigo == 3){
      total = v3 * quantidade;
      Console.WriteLine("O Valor total do X-Bacon é :R$ " + total );    
    }
    else if (codigo == 4){
      total = v4 * quantidade;
      Console.WriteLine("O Valor total do Torrada Simples é :RS" + total);
    }
    else if (codigo == 5){
      total = v5 * quantidade;
      Console.WriteLine("O Valor total do Refrigerante é :R$ " + total );  
    }
    else if (codigo > 5){
      Console.WriteLine("Código Inválido");
      Console.WriteLine ("Digite 1 para Cachorro Quente, 2 para X-Salada, 3 para X-Bacon, 4 para T, 5 para Refrigerante"  );

    }
      

    
    
  }
}