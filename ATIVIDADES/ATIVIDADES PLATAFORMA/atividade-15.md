## Exercício da Plataforma
Desenvolva um programa que recebe do usuário nome completo e ano de nascimento que seja entre 1922 e 2021. A partir dessas informações, o sistema mostrará o nome do usuário e a idade que completou, ou completará, no ano atual (2022). Caso o usuário não digite um número ou apareça um inválido no campo do ano, o sistema informará o erro e continuará perguntando até que um valor correto seja preenchido.
<hr>

> <a href="https://dotnetfiddle.net/Psvzye" target="_blank">:link: Código</a>

```cs
using System;
					
public class Program {
	
public static void Main() {
	bool x = true;
		
	while (x) {
		try {
			Console.WriteLine();
			Console.WriteLine("-------------- ATIVIDADE SOFTEX --------------");
				
			Console.Write("Digite seu nome completo: ");
			string nomeCompleto = Console.ReadLine();
				
			Console.Write("Digite seu ano de nascimento: ");
			int temp_AnoNascimento = Convert.ToInt32(Console.ReadLine());
			int anoNascimento = temp_AnoNascimento >= 1922 && temp_AnoNascimento <= 2022 ? temp_AnoNascimento : throw new Exception();
				
			Console.WriteLine(dadosUsuario(nomeCompleto, anoNascimento));
			x = false;
			
		} catch (Exception) {
			Console.WriteLine("Preencha com um ano de nascimento entre 1922 e 2022.");
		}
	}
}
	
private static string dadosUsuario(string nomeCompleto, int anoNascimento) {
		int anoAtual = DateTime.Now.Year;		
		return $"Seu nome: {nomeCompleto}, sua idade: {anoAtual - anoNascimento}";
	}
}
```
