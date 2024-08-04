# RabbitMQ Playground

Este é um repositório para testes a aprendizado sobre RabbitMQ. 

Não tem foco profissional, mas de disponibilizar um contato fácil e breve da tecnologia de mensageria em questão.

## Requisitos:
- .NET 8+
- docker

## Configuração
Rodar o seguinte comando no terminal para criação do container contendo o RabbitMQ:
```
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.13-management
```
Mais informações sobre configuração e acesso ao RabbitMQ: https://www.rabbitmq.com/

## Execução
A partir deste ponto, é só executar cos projetos como preferir. Divirta-se!