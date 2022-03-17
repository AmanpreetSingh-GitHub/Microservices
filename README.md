# Microservices Architecture #

<br />

## Solution Architecture ##

<br />

<img src="Solution Items/Images/1.PNG" style="border:1px solid darkgrey">


<br />

## Technologies used in the solution ##

<br />

Sample e-commerce solution uses a host of technologies to create multiple microservices along with inter-services synchronous communication, inter-services asynchronous communication, Clean Architecture, Event Driven Architecture using Message Broker, following Api Gateway, Aggregator, CQRS and MediatR patterns.

Below are the detailed technologies used in the solution -


- .Net Core
- Docker
- Ocelot Api Gateway
- MongoDB
- Redis Cache
- PostgreSQL
- SQL Server
- RabbitMQ
- MassTransit
- gRPC
- RESTful Api
- Message Broker
- MediatR
- Dapper
- Entity Framework Core
- Microservices Architecture
- Event Driven Architecture
- CQRS pattern (Command and Query Responsibility Segregation)
- Mediator pattern

<br />

## Microservices created as part of e-commerce solution ##

<br />

- Catalog microservice
    - Uses containerized MongoDB image
- Basket microservice
    - Uses containerized Redis Cache image
    - Calls Discount microservice for inter-service synchronous gRPC communication
    - Uses RabbitMQ and MassTransit for inter-service asynchronous communication to communicate with Ordering microservice
- Discount microservice
    - Uses containerized PostgreSQL image
    - Called by Basket microservice for inter-service synchronous gRPC communication
- Ordering microservice
    - Uses containerized SQL Server image
    - Uses RabbitMQ and MassTransit for inter-service asynchronous communication to communicate with Basket microservice
- Ocelot API Gateway microservice
    - Implements Api Gateway pattern for all communication between Catalog/Basket/Ordering microservices and outside world
- Shopping.Aggregator microservice
    - Implements Gateway Aggregator pattern that aggregate calls to multiple microservices like Catalog/Basket/Ordering
- ShoppingWebApp
    - Implements the front-end client application
    - Interacts with Ocelot Api Gateway for communicating with microservices


<br />

## References ##

<br />

- Original repository: https://github.com/aspnetrun/run-aspnetcore-microservices
- Portainer: https://docs.portainer.io/v/ce-2.11/start/intro
- pgAdmin: https://hub.docker.com/r/dpage/pgadmin4
- Microsoft SQL Server: https://hub.docker.com/_/microsoft-mssql-server
- Rabbitmq: https://hub.docker.com/_/rabbitmq
