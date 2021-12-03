CREATE DATABASE App;

USE App;

CREATE TABLE Users(
Id_user INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Nom_user VARCHAR(30) NOT NULL,
Ape_user VARCHAR(30) NOT NULL,
Usuario VARCHAR(30) NOT NULL,
Pass VARCHAR(30) NOT NULL,
Email VARCHAR(200) NOT NULL,
Cen_vac VARCHAR(200) NOT NULL
);

CREATE TABLE Citas(
Ide_Cita INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Centro VARCHAR(30) NOT NULL,
Fecha VARCHAR(30) NOT NULL,
Hora VARCHAR(30) NOT NULL,
);

INSERT INTO Citas VALUES ('Club Los Prados','03/04/2021','8:30 AM');
INSERT INTO Citas VALUES ('Club Los Prados','03/07/2021','7:30 AM');
INSERT INTO Citas VALUES ('Club Los Prados','03/08/2021','10:30 AM');
INSERT INTO Citas VALUES ('Club Los Prados','03/12/2021','12:00 PM');

INSERT INTO Users VALUES ('Sameer','Brito','Admin','Admin','sameerbrito79@gmail.com','Club Los Prados');

SELECT *FROM Users