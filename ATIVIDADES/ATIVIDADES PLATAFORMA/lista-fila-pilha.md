## Exercício da Plataforma - Lista, fila e pilhas
Considere o array [3, 7, 9, 1, 0].

O primeiro elemento inserido foi o 3, o segundo foi o 7 e assim por diante, seguindo a ordem.

Levando em conta as três estruturas de dados (fila, lista e pilha) e as suas regras de operações, qual seria a sequência dos números removidos em cada uma delas para esvaziá-las completamente utilizando o array mencionado?

<a href="https://codepen.io/DanielGNB/pen/mdQoWMG?editors=0011" target="_blank">:link: Código</a>

```js
let fila = [3, 7, 9, 1, 0]
let lista = [3, 7, 9, 1, 0]
let pilha = [3, 7, 9, 1, 0]

// Fila:
while (fila.length != 0) {
  fila.shift()
}
// Lista:
while (lista.length != 0) {
  lista.pop()
}
// Pilha:
while (pilha.length != 0) {
  pilha.pop()
}

console.log(fila)
console.log(lista)
console.log(pilha)
```
