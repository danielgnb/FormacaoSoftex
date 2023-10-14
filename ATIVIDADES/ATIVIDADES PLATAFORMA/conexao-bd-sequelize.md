## Exercício da Plataforma - Conexão com Banco de Dados
Implemente e trate uma conexão com o seu banco de dados, usando JavaScript. Caso a conexão com o banco tenha sucesso, ele deve retornar uma frase positiva. Se isso não ocorrer, retorne uma frase informando o erro.

```js
// Arquivo de conexão com o banco de dados: conexao-bd.js
const Sequelize = require('sequelize')
const sequelize = new Sequelize('Daniel','','',{
    host: 'DESKTOP-RT4N3AT',
  dialect: 'mssql',
  port: 1433,
  dialectOptions: {
    instanceName: 'LOCALDB#8C891E64',
    options: {
      encrypt: false,
    },
  },
})
module.exports = sequelize;

// Arquivo de autenticação com o banco de dados: conexao-bd-sequelize.js
const bancodedados = require('./conexao-bd')

const conexaoBD = async () =>{
    try {
        await bancodedados.authenticate()
        console.log(`Conexão com sucesso!`)
    } catch (error) {
        console.log(`Erro na conexão: ${error.message}`)
    }
}
conexaoBD()
```