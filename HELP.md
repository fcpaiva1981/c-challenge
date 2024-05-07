# Funcionanmento da API

### Pré-requisitos

* Docker
* MySQL 8.x
* Executar o docker-compose.yml do MySQL para instanciar o banco
* Aplicação escrita em .NET 8

### Funcionamento da API

* Montando a imagem
    * Acesse o path da aplicação: cd ..\..\ApiChallengeCSharp
    * No path da aplicação executar o comando : docker build -t counter-image -f Dockerfile .
    * Será criado uma imagem da aplicação
* Acesso a documentação da aplicação
* http://localhost:8080/swagger/index.html