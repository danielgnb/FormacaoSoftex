## Atividade da Plataforma - Tipos de Variáveis
#### Vamos criar um cadastro de pessoa com os seguintes dados: nome, salário, idade e se possui diploma. Antes de começar a codificação, identifiquem os tipos de cada variável. Em seguida, desenvolvam o código utilizando exemplos para cada variável que respeitem os tipos identificados. Certifiquem-se de que os valores correspondam aos tipos de dados corretos.

> <a href="https://codepen.io/DanielGNB/pen/qBLoPbB?editors=0011" target="_blank">:link: Código</a>

```js
const tipoVariavel = (x) => console.log(typeof x)
alert('------- CADASTRO DE PESSOA -------')
const nome = prompt('Nome: ')
const salario = parseFloat(prompt('Salário: '))
const idade = parseInt(prompt('Idade: '))
const possuiDiploma = prompt('Possui diploma?\nSim ou Não') == "Sim" ? true : false
const dadosPessoais = [nome, salario, idade, possuiDiploma]
dadosPessoais.map(tipoVariavel)
alert(`Dados pessoais:\nNome: ${nome}, Salário: ${(salario).toFixed(3)}, Idade: ${idade} anos, Possui Diploma: ${possuiDiploma}`)
```
