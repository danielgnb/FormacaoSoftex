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