## Exercício da Plataforma - Arrays
Você deve criar três listas em JavaScript:

1. para guardar os nomes de dez pessoas;
2. para guardar as suas idades;
3. para guardar as suas cores favoritas.

Em seguida, imprima essas listas. Depois, faça algumas modificações, alterando uma cor e uma idade. Ao terminar, imprima novamente todas as informações das três listas.

> <a href="https://codepen.io/DanielGNB/pen/JjexyOp?editors=0011" target="_blank">:link: Código</a>

```js
let nomes = []
let idades = []
let coresFavoritas = []

for (let i = 0; i < 10; i++) {
  nomes.push(prompt('Nome: '))
  idades.push(parseInt(prompt('Idade: ')))
  coresFavoritas.push(prompt('Cor favorita: '))
}

alert(`Nomes: ${nomes.map((n) => n)}`)
alert(`Idades: ${idades.map((i) => i)}`)
alert(`Cores: ${coresFavoritas.map((c) => c)}`)

idades[1] = 99
coresFavoritas[0] = 'Preto fosco'

alert(`Nomes: ${nomes.map((n) => n)}`)
alert(`Idades: ${idades.map((i) => i)}`)
alert(`Cores: ${coresFavoritas.map((c) => c)}`)
```
