# 2026-emne8-arbeidskrav
Arbeidskrav for emne 8 - Cloud-teknikker, web-arkitektur og containerteknologi 
**Utviklere:** Benjamin Myhre Søiland og Marcus Hidle Brustad
**Leveringsdato:** 30.01.2026


## Prosjektet
 
Prosjektet går ut på å lage et docker-compose oppsett for koblingen mellom database — api — web. 

Det er et veldig simpelt API som gjør lite annet enn å hente ut string verdi fra tabell i PostgreSQL database.

Fokuset av projektet var satt på koblingen mellem tjenestene, hvor hver av dem har hver sin Dockerfile som bygges via docker-compose.

## Teknologier

- .NET 10
- PostgreSQL (Med forslag fra lærer ble det brukt PostgreSQL istedenfor MySQL.)
- Docker
- DockerHub
- NGINX


## Oppsett

Begge har pushet containere til sin egen DockerHub.  

[Marcus](https://hub.docker.com/repositories/brustad "Docker huben til Marcus")

[Benjamin](https://hub.docker.com/repositories/bensoil "Dockerhuben til Benjamin")

I docker-compose er det satt opp til Benjamins hub sånn at det er satt til én hub og skal kunne kjøres rett som det er.

## Instruksjoner

For å starte opp, er det bare å kjøre kommandoen `docker-compose up -d` fra command line verktøyet, så kjøres containerne opp.

Når alle 3 er oppe og kjører skal du kunne komme deg inn ved å bare gå til URLen [localhost/api/lifesmeaning](http://localhost/api/lifesmeaning)

Viktig å presisere at det kjører med **http** istedenfor https, men det skal fungere å bare trykke URL linken der oppe.