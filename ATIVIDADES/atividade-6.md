Levando em consideração os aprendizados sobre as estruturas condicionais, elabore um algoritmo que possa descobrir, através de perguntas e respostas, qual é o meio de transporte que o usuário está considerando. O usuário deverá escolher uma das seguintes opções:

- trator; 
- moto; 
- bicicleta. 

Para chegar ao resultado, as perguntas precisam ser respondidas apenas com "Sim" ou "Não".

Exemplo:
É terrestre? Sim.
Cabe apenas uma pessoa? Sim.
É pesado? Não.
Tem pedal? Sim.
Então, o transporte escolhido foi a bicicleta.

Para chegar ao resultado de cada uma das opções, use o modelo em anexo.
<hr>
Essa atividade é foi um pouco confusa de fazer por dar muita margem para determinadas respostas.
Utilizei a linguagem C# para fazê-la.

- Código funcionando: <a>https://onlinegdb.com/onToD_T4s</a>
- Código:
``` cs
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
```