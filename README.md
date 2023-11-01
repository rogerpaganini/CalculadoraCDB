# Projeto Calculadora CDB

Esse projeto simula uma calculadora de investimento CDB, onde o usuário informa o valor desejado da aplicação e a quantidade de meses, retornando o valor total bruto e o valor liquido menos os impostos.

A solução é composta por uma API backend e uma aplicação web.

## Como funciona o CDB? 

O CDB funciona como um empréstimo do seu dinheiro para uma instituição bancária e, em troca, você recebe uma taxa de rentabilidade que é definida no momento da compra. Assim, ao adquirir um CDB, você está emprestando dinheiro ao banco emissor por um determinado prazo.

## Conceitos aplicados
- TDD
- DDD
- Arquitetura Limpa
- SOLID

## BackEnd
- .Net Core 7
- Xunit
- Moq
- Swagger
- Visual Studio 2022

## Servidor de desenvolvimento 
- Clone o repositório para sua máquina local.
- Abra a solution "CalculadoraCDB.sln" com o Visual Studio e rode o projeto.
- Irá abrir o Swagger da Api.

## Servidor de desenvolvimento testes de unidade
- No menu superior do Visual Studio, clique em Teste - Executar todo os testes.

#### FrontEnd
- Angular CLI 16.2
- Node.js
- Bootstrap
- VS Code

### Servidor de desenvolvimento front-end
- Abra a pasta "CalculadoraCDB.Web" no VS Code.
- Na aba "Terminal", clique na opção "New Terminal". Em seguida digite o comando "npm install" para instalar todas as dependências do projeto.
- Execute ng serve para rodar o projeto. Navegue para http://localhost:4200/

### Frontend executando testes de unidade
- Na aba Terminal execute ng test para executar os testes unitários via Karma
