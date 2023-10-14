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