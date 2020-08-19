using System;

class MainClass {

  // Main para Rodar as Funções dos Exercicios
  public static void Main (string[] args) {
    
    Ex04();
    
  }

  // Função do Exercicio 01
  public static void Ex01(  ){
    Console.WriteLine( "Ola Mundo!" );
  }

  // Função do Exercicio 02
  public static void Ex02(  ){
    Console.Write("Informe um Numero: ");
    int numero = int.Parse( Console.ReadLine() );

    Console.WriteLine( "O numero informado foi {0}", numero );
  }

  // Função do Exercicio 03
  public static void Ex03(  ){
    Console.Write("Informe o primeiro Numero: ");
    float n1 = float.Parse( Console.ReadLine() );

    Console.Write("Informe o segundo Numero: ");
    float n2 = float.Parse( Console.ReadLine() );

    Console.WriteLine("Soma de {0} + {1} = {2}", n1, n2, n1+n2 );
  }

  // Função do Exercicio 04
  public static void Ex04(  ){
    Console.Write("Informe a primeira Nota: ");
    float n1 = float.Parse( Console.ReadLine() );

    Console.Write("Informe a segunda Nota: ");
    float n2 = float.Parse( Console.ReadLine() );

    Console.Write("Informe a terceira Nota: ");
    float n3 = float.Parse( Console.ReadLine() );

    Console.Write("Informe a quarta Nota: ");
    float n4 = float.Parse( Console.ReadLine() );

    float media = ( n1 + n2 + n3 + n4 ) / 4 ;

    Console.WriteLine( "A medias das notas e: {0}", media );


  }


}