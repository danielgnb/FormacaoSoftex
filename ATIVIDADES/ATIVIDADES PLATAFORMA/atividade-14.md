## Exercícios da Plataforma - Funções
### Faça, utilizando o Google Blockly, uma função calculadora que os números e as operações serão feitas pelo usuário. O código deve ficar rodando infinitamente até que o usuário escolha a opção de sair. No início, o programa mostrará a seguinte lista de operações:
- 1: Soma
- 2: Subtração
- 3: Multiplicação
- 4: Divisão
- 0: Sair

Digite o número para a operação correspondente e caso o usuário introduza qualquer outro, o sistema deve mostrar a mensagem “Essa opção não existe” e voltar ao menu de opções.
Após a seleção, o sistema deve pedir para o usuário inserir o primeiro e segundo valor, um de cada. Depois precisa executar a operação e mostrar o resultado na tela. Quando o usuário escolher a opção “Sair”, o sistema irá parar. 
É necessário que o sistema mostre as opções sempre que finalizar uma operação e mostrar o resultado.
> <a href="https://codepen.io/DanielGNB/pen/YzRJRMB?editors=0012" target="_blank">:link: Código Funcionando</a>
```js
const calculadora = () => {
  let validacao = true;

  while (validacao) {
    let operacao = parseInt(prompt("Qual operação você deseja realizar?\n1-SOMA 2-SUBTRAÇÃO 3-MULTIPLICAÇÃO 4-DIVISÃO 0-SAIR"));
    if (operacao != 0) {
      let valor1 = parseFloat(prompt("Digite um valor para ser calculado: "));
      let valor2 = parseFloat(prompt("Digite outro valor para ser calculado: "));

      if (!isNaN(valor1) && !isNaN(valor2) && !isNaN(operacao)) {
        switch (operacao) {
          case 1:
            alert(`A soma de ${valor1}+${valor2} é: ${valor1 + valor2}`);
            break;
          case 2:
            alert(`A subtração de ${valor1}-${valor2} é: ${valor1 - valor2}`);
            break;
          case 3:
            alert(`A multiplicação de ${valor1}x${valor2} é: ${valor1 * valor2}`);
            break;
          case 4:
            alert(`A divisão de ${valor1}/${valor2} é: ${valor1 / valor2}`);
            break;
          case 0:
            validacao = false;
            break;
          default:
            alert("Essa opção não existe!");
            break;
        }
      } else {
        alert("Digite valores numéricos");        
      }
    } else {
      validacao = false;
    }
  }
};

calculadora();
```
