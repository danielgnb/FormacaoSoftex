## Exercício da Plataforma - Tratamento de Exceções
Utilizando a linguagem JavaScript, crie uma situação matemática na qual os números precisam ser informados pelo usuário. Além disso, deve ocorrer uma exceção dentro do código. Utilize os métodos try(), catch() e finally() para realizar a captura e o tratamento dessa exceção.

> <a href="https://codepen.io/DanielGNB/pen/NWoWjqJ?editors=0010" target="_blank">:link: Código</a>

```js
const soma = (valor1, valor2) => {
  try {
    if(isNaN(valor1) || isNaN(valor2)){
      throw 'Valor incorreto'
    }else{
    console.log(parseInt(valor1) + parseInt(valor2))
    }    
  } catch(error) {
    console.log(error)
  } finally {
    console.log('Operação finalizada.')
  }
}

soma('b','5')
```
