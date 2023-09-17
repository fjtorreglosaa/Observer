Use the following commands to setup the environment

1. Setup the database using Docker

- Postgres Image: docker pull postgres:16.0-alpine3.18
- PgAdmin Image: docker pull dpage/pgadmin4:7
- Volume: docker volume create ObserverData
- Postgres Container: docker container run --name TestServer_Postgres -p 5432:5432 -v ObserverData:/var/lib/postgresql/data -e POSTGRES_PASSWORD=Password1* -d postgres:16.0-alpine3.18
- PgAdmin Container: docker container run -p 8080:80 --name TestServer_PgAdmin -e PGADMIN_DEFAULT_PASSWORD=Password1* -e PGADMIN_DEFAULT_EMAIL=user@domain.com -d dpage/pgadmin4:7
- Network: docker network create Postgres_Network
- Add PgAdmin to the Network: docker network connect Postgres_Network <PostgresContainerId>
- Add Postgres to the Network: docker network connect Postgres_Network <PgAdminContainerId>

What we will learn?

- Docker (image, container, volume, network)
- Clean Architecture (Drive Domain Design)
- Dapper Micro-ORM
- Repository pattern
- Unit of work pattern
- CQRS pattern
- Mediator pattern
- Observer pattern
- Chain of responsability pattern
- Web API Fundamentals
