using System;
      
 class Program {
 public static void Main (string[] args) {
//declara uma variavel do tipo inteiro e uma do tipo caractere(texto)
// a variavel string recebe o valor digitado e armazena. Toda entrada é sempre um texto
  
  Int16 num;
  String entrada;
 //escreval 
     Console.WriteLine ("Digite um número");
// Leia
      entrada=Console.ReadLine();
//converte a entrada em texto no formato númerico
      num = Int16.Parse(entrada);
//se(num%2=0) entao
//C# a comparação é feita com == 
      if (num%2==0)
      {Console. WriteLine("Numero Par");
      }  
 else {Console.WriteLine ("Numero Impar");
           }
          
    }
  }