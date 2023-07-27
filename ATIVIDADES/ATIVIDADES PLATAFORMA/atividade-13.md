## Exercícios da Plataforma - Funções
### Faça uma função calculadora de dois números com três parâmetros: os dois primeiros serão os números da operação e o terceiro será a entrada que definirá a operação a ser executada. Considera a seguinte definição:
1. Soma
2. Subtração
3. Multiplicação
4. Divisão

Caso seja inserido um número de operação que não exista, o resultado deverá ser 0.
> <a href="https://codepen.io/DanielGNB/pen/JjemeWr?editors=0010" target="_blank">:link: Código Funcionando</a>
```js
let operacoes = [1, 2, 3, 4];
const calculadora = (valor1, valor2, operacao) => {
  if (!isNaN(valor1) || !isNaN(valor2) || !isNaN(operacao) || !operacoes.includes(operacao)) {
    switch (operacao) {
      case 1:
        return alert(`A soma de ${valor1}+${valor2} é: ${valor1 + valor2}`);
      case 2:
        return alert(`A subtração de ${valor1}-${valor2} é: ${valor1 - valor2}`);
      case 3:
        return alert(`A multiplicação de ${valor1}x${valor2} é: ${valor1 * valor2}`);
      case 4:
        return alert(`A divisão de ${valor1}/${valor2} é: ${valor1 / valor2}`);
      default:
        break;
    }
  }
  return alert(0);
};

const operacaoEscolhida = parseInt(prompt("Qual operação você deseja realizar?\n1-SOMA 2-SUBTRAÇÃO 3-MULTIPLICAÇÃO 4-DIVISÃO"));
const valor1 = parseFloat(prompt("Digite um valor para ser calculado: "));
const valor2 = parseFloat(prompt("Digite outro valor para ser calculado: "));
calculadora(valor1,valor2,operacaoEscolhida)
```
