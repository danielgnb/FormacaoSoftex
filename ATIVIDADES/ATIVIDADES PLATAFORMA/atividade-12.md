## Exercícios da Plataforma - Laços de Repetição

### Faça um código, utilizando o Google Blockly, que execute a contagem regressiva de uma bomba, informando o número de segundos para explodir. Ele deverá mostrar a mensagem “iniciando contagem regressiva”, os segundos passados e, no final, a mensagem “BUM!”.
> <a href="https://codepen.io/DanielGNB/pen/ZEmqMVM?editors=0011" target="_blank">:link: Código Funcionando</a>
```js
const bombaRelogio = async function(segundosExplosao) {
  if (!isNaN(segundosExplosao)) {
    console.log('Iniciando contagem regressiva...');
    for (let i = 0; i <= segundosExplosao; i++) {
        console.log(i)
        await new Promise(resolve => setTimeout(resolve, 1000));
    }
  console.log('BUM!');
  } else {
    alert('Insira um valor númerico.')
  }
}

bombaRelogio(parseInt(prompt("Insira um valor para a contagem regressiva: ")))
```
