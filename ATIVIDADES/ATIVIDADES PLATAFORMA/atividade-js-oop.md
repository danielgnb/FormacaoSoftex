## Exercício da Plataforma - Conexão com Banco de Dados
Com base no que estudamos, escolha dois objetos materiais e dois abstratos. Em seguida, faça uma lista com, pelo menos, três atributos e três métodos para cada tipo de objeto. Para finalizar, demonstre esses objetos em JavaScript e exemplifique as suas características e ações.

> <a href="https://codepen.io/DanielGNB/pen/JjxgwPM" target="_blank">:link: Código</a>

```js
let carro = {
  modelo: "Sedan",
  cor: "Prata",
  velocidadeAtual: 0,
  acelerar: function(velocidade) {
    this.velocidadeAtual += velocidade;
    console.log(`Acelerando para ${this.velocidadeAtual} km/h.`);
  },
  frear: function() {
    this.velocidadeAtual = 0;
    console.log("Freando o carro.");
  },
  ligar: function() {
    console.log("Ligando o carro.");
  }
};

let livro = {
  titulo: "O Senhor dos Anéis",
  autor: "J.R.R. Tolkien",
  numPaginas: 1000,
  abrir: function() {
    console.log("Abrindo o livro.");
  },
  fechar: function() {
    console.log("Fechando o livro.");
  },
  ler: function() {
    console.log("Lendo o livro.");
  }
};

let contaBancaria = {
  saldo: 1000,
  numeroConta: "123456",
  nomeTitular: "João Silva",
  depositar: function(valor) {
    this.saldo += valor;
    console.log(`Depositando R$ ${valor}. Saldo atual: R$ ${this.saldo}`);
  },
  sacar: function(valor) {
    if (valor <= this.saldo) {
      this.saldo -= valor;
      console.log(`Sacando R$ ${valor}. Saldo atual: R$ ${this.saldo}`);
    } else {
      console.log("Saldo insuficiente.");
    }
  },
  consultarSaldo: function() {
    console.log(`Saldo atual: R$ ${this.saldo}`);
  }
};

let calendario = {
  mesAtual: "Janeiro",
  anoAtual: 2023,
  diaSemana: "Segunda-feira",
  avancarMes: function() {
    console.log("Avançando para o próximo mês.");
  },
  retrocederMes: function() {
    console.log("Retrocedendo para o mês anterior.");
  },
  exibirDataAtual: function() {
    console.log(`Data atual: ${this.diaSemana}, ${this.mesAtual} de ${this.anoAtual}`);
  }
};

carro.ligar();
carro.acelerar(50);
livro.abrir();
contaBancaria.depositar(500);
calendario.exibirDataAtual();
```
