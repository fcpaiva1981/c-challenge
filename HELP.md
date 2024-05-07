# Funcionanmento da API

### Especificações

* Docker
* MySQL 8.x
* Aplicação escrita em .NET 8

### Pré-requisitos
   * Acessar a pasta: ..\..\banco
   * Executar o comando : docker build -t counter-image -f Dockerfile .
   
### Funcionamento da API

* Montando a imagem
    * Acesse o path da aplicação: cd ..\..\ApiChallengeCSharp
    * No path da aplicação executar o comando : docker build -t counter-image -f Dockerfile .
    * Será criado uma imagem da aplicação
* Acesso a documentação da aplicação
* http://localhost:8080/swagger/index.html