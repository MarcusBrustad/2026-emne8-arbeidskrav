drop database if exists MeaningOfLifeDb;
create database MeaningOfLifeDb;
use MeaningOfLifeDb;
# create user
CREATE USER IF NOT EXISTS 'ga-app' @'localhost' IDENTIFIED BY 'secret123';
CREATE USER IF NOT EXISTS 'ga-app' @'%' IDENTIFIED BY 'secret123';
GRANT ALL privileges ON MeaningOfLifeDb.* TO 'ga-app' @'%';
GRANT ALL privileges ON MeaningOfLifeDb.* TO 'ga-app' @'localhost';
FLUSH PRIVILEGES;