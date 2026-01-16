FROM mysql:latest

COPY meaning_of_life_dump.sql /docker-entrypoint-initdb.d/
COPY MeaningOfLifeDb_user_privileges.sql /docker-entrypoint-initdb.d/

EXPOSE 3306