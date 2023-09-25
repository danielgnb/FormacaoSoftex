## Atividade da Plataforma - Calculadora de Média
#### A atividade que faremos é a da “calculadora de média”. Para isso, você deve criar um programa JavaScript que calcule a média de três notas inseridas pelo usuário e exiba o resultado no console. Primeiro, solicite que o usuário insira três notas (entre 0 e 10) usando a função prompt(). Elas devem ser armazenadas em variáveis adequadas, por exemplo, nota1, nota2 e nota3, com o tipo de dado Number. Depois, some-as e divida por três. O resultado deste cálculo será o valor da média, que deve ser armazenado em uma variável chamada media. Por fim, exiba esse valor no console usando a função console.log().
> <a href="https://codepen.io/DanielGNB/pen/WNLzOvW?editors=0012" target="_blank">:link: Código</a>
```js
function calcularMedia (nota1, nota2, nota3) {
  return ((nota1+nota2+nota3) / 3).toFixed(2)
}

let nota1 = parseFloat(prompt('Nota 1: '))
let nota2 = parseFloat(prompt('Nota 2: '))
let nota3 = parseFloat(prompt('Nota 3: '))
const media = parseFloat(calcularMedia(nota1, nota2, nota3))
console.log(media)
```
