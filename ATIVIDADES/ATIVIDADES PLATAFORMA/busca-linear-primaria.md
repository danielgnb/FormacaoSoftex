## Exercícios da Plataforma - Busca linear e primária
Temos o array [15, 8, 10, 25, 12, 30, 5, 20, 18, 7] e precisamos criar um código em JavaScript para encontrar o valor 20.

Para isso, temos que escolher entre realizar uma busca linear ou binária de acordo com a que for mais adequada para essa situação.

Codifique a solução mais eficiente para buscar o número 20 no array.

> <a href="https://codepen.io/DanielGNB/pen/ZEmZYWz?editors=0010" target="_blank">:link: Código</a>

```js
const buscaLinear = (array) => {
  for (let i = 0; i < array.length; i++) {
    if (array[i] === 20) {
      return i
    }
  }
}
const array = [15, 8, 10, 25, 12, 30, 5, 20, 18, 7];
alert(buscaLinear(array))
```
