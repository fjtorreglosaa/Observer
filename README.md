Use the following commands to setup the environment

1. Setup the database using Docker

- Image: docker pull postgres:16.0-alpine3.18
- Volume: docker volume create ObserverData
- Container: docker container run --name TestServer_Postgres -p 5432:5432 -v ObserverData -e POSTGRES_PASSWORD=Password1* -d postgres:16.0-alpine3.18

3. What we will learn?

- Clean Architecture (Drive Domain Design)
- Dapper Micro-ORM
- Repository pattern
- Unit of work pattern
- CQRS pattern
- Mediator pattern
- Observer pattern
- Chain of responsability pattern
- Web API Fundamentals
