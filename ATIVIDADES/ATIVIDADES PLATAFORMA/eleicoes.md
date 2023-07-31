## Exercício da Plataforma - Eleições
Desenvolva um código que simule uma eleição com três candidatos.
- candidato_X => 889
- candidato_Y => 847
- candidato_Z => 515
- branco => 0

O código deve perguntar se deseja finalizar a votação depois do voto. Caso o número do voto não corresponda a nenhum candidato ou seja branco, ele deve ser tratado como nulo. Se for inserido um texto ao invés de número, o código deve retornar uma mensagem para votar novamente.

Quando a votação for finalizada, o código deverá mostrar o vencedor, aquele com o maior número de votos e, também, a quantidade de votos de cada candidato, os brancos e nulos. 

> <a href="https://codepen.io/DanielGNB/pen/GRwPWra?editors=0012" target="_blank">:link: Código</a>

```js
let eleicoes = [
  { id: 889, candidato: "Candidato_X", votos: [] },
  { id: 847, candidato: "Candidato_Y", votos: [] },
  { id: 515, candidato: "Candidato_Z", votos: [] },
  { id: 0, candidato: "Brancos", votos: [] },
  { candidato: "Nulos", votos: [] }
];

const votacao = () => {
  let validacao = true;
  let voto;

  while (validacao) {
    try {
      voto = parseInt(prompt("ESCOLHA O SEU VOTO\nCandidato_X: 889 - Candidato_Y: 847 - Candidato_Z: 515 - Branco: 0"));
      validacao = prompt("DESEJA CONTINUAR A VOTAÇÃO?\nDigite: Sim ou Não") === "Sim" ? true : false;

      if (!isNaN(voto)) {
        let candidato = eleicoes.find((candidato) => candidato.id === voto);
        if (candidato) {
          candidato.votos.push(1);
        } else {
          eleicoes[4].votos.push(1);
        }
      }
    } catch (ex) {
      validacao = true;
    }
  }
  const vencedor = eleicoes.reduce((candidatoVencedor, candidatoAtual) =>
    candidatoAtual.votos.length > candidatoVencedor.votos.length
      ? candidatoAtual
      : candidatoVencedor
  );

  return alert(`O vencedor foi: ${vencedor.candidato}\n
                ${eleicoes[0].candidato}: ${eleicoes[0].votos.length} votos\n
                ${eleicoes[1].candidato}: ${eleicoes[1].votos.length} votos\n
                ${eleicoes[2].candidato}: ${eleicoes[2].votos.length} votos\n
                ${eleicoes[3].candidato}: ${eleicoes[3].votos.length} votos\n
                ${eleicoes[4].candidato}: ${eleicoes[4].votos.length} votos`);
};

votacao();
```
