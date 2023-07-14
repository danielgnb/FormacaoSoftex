/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;
using System.Collections.Generic;

class Softex {
  static void Main() {
    var answer = string.Empty;
    
    Console.WriteLine("--- Escolha seu meio de transporte ---");
    Console.WriteLine("-- Utilize: \"Sim\" ou \"Não\" como resposta --");
    Console.WriteLine();

    Console.Write("É terrestre? ");
    answer = Console.ReadLine();
    if (ValidateAnswer(answer)){
      Console.Write("Cabe apenas uma pessoa? ");
      answer = Console.ReadLine();
      if (ValidateAnswer(answer)) {
          Console.Write("É pesado? ");
          answer = Console.ReadLine();
          if (ValidateAnswer(answer)) {
              Console.WriteLine("Então, o transporte escolhido foi o trator.");
          } else {
              Console.WriteLine("Então, o transporte escolhido foi a bicicleta.");
          }
      } else {
          Console.Write("Tem pedal? ");
          answer = Console.ReadLine();
          if (ValidateAnswer(answer)) {
              Console.WriteLine("Então, o transporte escolhido foi o bicicleta.");
          } else {
              Console.WriteLine("Você não escolheu transporte nenhum.");
          }
      }
    } 
     else {
      Console.Write("Usa capacete? ");
      answer = Console.ReadLine();
      if (ValidateAnswer(answer)) {
              Console.WriteLine("Então, o transporte escolhido foi o moto.");
          } else {
              Console.WriteLine("Você não escolheu transporte nenhum.");
          }
    }
  }
  
  private static bool ValidateAnswer (string answer) {
    try {
      var positiveAnswers = new List<string>() {"SIM", "SIM."};
      var negativeAnswers = new List<string>() {"NÃO", "NÃO."};
      
      if (positiveAnswers.Contains(answer.ToUpper())){
          return true;
        } else if (negativeAnswers.Contains(answer.ToUpper())){
          return false;
        } else {
            throw new ArgumentException("Utilize: \"Sim\" ou \"Não\" como resposta", answer);
        }      
    } catch (Exception) {
        throw;
    }
  } 
}