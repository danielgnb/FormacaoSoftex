## Exercício da Plataforma - Objetos
Ele deverá ter propriedades que incluem conta, saldo, tipo de conta e agência e os seus métodos devem ser: buscar saldo, depósito, saque e número da conta.
- Observações
  - buscar saldo deve retornar o valor atual do saldo;
  - para o depósito, você deverá passar um valor como parâmetro e adicioná-lo no saldo final do objeto;
  - para o saque, você deverá passar um valor como parâmetro e subtraí-lo no saldo final do objeto;
  - o número da conta deve retornar o número da conta.

 > <a href="https://codepen.io/DanielGNB/pen/KKbxxqL?editors=0012" target="_blank">:link: Código</a>

```js
const deposito = (objBanco, valor) => {
  objBanco.saldo = objBanco.saldo + valor
  return 'Depósito realizado!'
}
const saque = (objBanco, valor) => {
  objBanco.saldo = objBanco.saldo - valor
  return 'Saque realizado!'
}
const buscar_saldo = (objBanco) => objBanco.saldo
const numero_conta = (objBanco) => objBanco.conta

let banco = {
  conta: 29740,
  saldo: 1500,
  tipo_conta: 'Débito',
  agencia: 455,
  buscar_saldo: buscar_saldo,
  numero_conta: numero_conta,
  deposito: deposito,
  saque: saque
}

alert(`---- BANCO ----\n
      Conta: ${banco.numero_conta(banco)}\n
      Saldo: ${banco.buscar_saldo(banco)}\n
      Depósito - R$ 1000: ${banco.deposito(banco, 1000)}\n
      Saldo: ${banco.buscar_saldo(banco)}\n
      Saque - R$ 500: ${banco.saque(banco, 500)}\n
      Saldo: ${banco.buscar_saldo(banco)}
`)
```
