CREATE DATABASE seriale_db;
GO

USE seriale_db;
GO

CREATE TABLE gatunki (
	id_gatunku int IDENTITY(1, 1) PRIMARY KEY,
	nazwa varchar(15) NOT NULL);

CREATE TABLE stacje_tv (
	id_stacji int IDENTITY(1, 1) PRIMARY KEY,
	nazwa varchar(15) NOT NULL);

CREATE TABLE seriale (
	id_serialu int IDENTITY(1, 1) PRIMARY KEY,
	nazwa varchar(30) NOT NULL,
	rok_rozpoczecia int NOT NULL,
	rok_zakonczenia int,
	id_gatunku_1 int,
	id_gatunku_2 int,
	id_gatunku_3 int,
	id_stacji int,
	ilosc_sezonow int NOT NULL CHECK(ilosc_sezonow>0),
	ilosc_odcinkow int NOT NULL CHECK(ilosc_odcinkow>0),
	czas_trwania_odcinka int,
	FOREIGN KEY (id_gatunku_1) REFERENCES gatunki(id_gatunku),
	FOREIGN KEY (id_gatunku_2) REFERENCES gatunki(id_gatunku),
	FOREIGN KEY (id_gatunku_3) REFERENCES gatunki(id_gatunku),
	FOREIGN KEY (id_stacji) REFERENCES stacje_tv(id_stacji));

CREATE TABLE do_obejrzenia (
	id_serialu int IDENTITY(1, 1) PRIMARY KEY,
	nazwa varchar(30) NOT NULL,
	rok_rozpoczecia int NOT NULL,
	rok_zakonczenia int,
	id_gatunku_1 int,
	id_gatunku_2 int,
	id_gatunku_3 int,
	id_stacji int,
	ilosc_sezonow int NOT NULL CHECK(ilosc_sezonow>0),
	ilosc_odcinkow int NOT NULL CHECK(ilosc_odcinkow>0),
	czas_trwania_odcinka int,
	FOREIGN KEY (id_gatunku_1) REFERENCES gatunki(id_gatunku),
	FOREIGN KEY (id_gatunku_2) REFERENCES gatunki(id_gatunku),
	FOREIGN KEY (id_gatunku_3) REFERENCES gatunki(id_gatunku),
	FOREIGN KEY (id_stacji) REFERENCES stacje_tv(id_stacji));

CREATE TABLE na_biezaco (
	lp int IDENTITY(1, 1) PRIMARY KEY,
	id_serialu int NOT NULL,
	FOREIGN KEY (id_serialu) REFERENCES seriale (id_serialu));

CREATE TABLE koniec (
	lp int IDENTITY(1, 1) PRIMARY KEY,
	id_serialu int NOT NULL,
	FOREIGN KEY (id_serialu) REFERENCES seriale (id_serialu));

CREATE TABLE nie_skonczone (
	lp int IDENTITY(1, 1) PRIMARY KEY,
	id_serialu int NOT NULL,
	FOREIGN KEY (id_serialu) REFERENCES seriale (id_serialu));

CREATE TABLE przerwa (
	lp int IDENTITY(1, 1) PRIMARY KEY,
	id_serialu int NOT NULL,
	FOREIGN KEY (id_serialu) REFERENCES seriale (id_serialu));

GO

INSERT INTO gatunki(nazwa) VALUES
	('Drama'),
	('Adventure'),
	('Comedy'),
	('Crime'),
	('Action');

INSERT INTO stacje_tv(nazwa) VALUES
	('HBO'),
	('Netflix'),
	('Prime Video'),
	('abc'),
	('CW');

INSERT INTO seriale VALUES
	('Modern Family', 2009, 2020, 3, 1, NULL, 4, 10, 250, 22),
	('The Boys', 2019, NULL, 5, 3, 4, 3, 2, 19, 60),
	('Game of Thrones', 2011, 2019, 5, 2, 1, 4, 17, 370, 41),
	('The Punisher', 2017, 2019, 5, 4, 1, 2, 2, 26, 53),
	('The Flash', 2014, NULL, 5, 2, 1, 5, 7, 138, 43);
	/*('Lucifer', 2016, NULL, 4, 1, NULL, 2, 5, 93, 42)
	('Adventure Time: Distant Lands', 2020, NULL, NULL, 5, 2, 1, 1, 2, 42)
	('Agents of S.H.I.E.L.D.', 2013, 2020, 5, 2, 1, 4, 7, 136, 45)
	('Orange Is The New Black', 2013, 2019, 3, 4, 1, 2, 7, 91, 59)*/

INSERT INTO do_obejrzenia VALUES
	('Tom Clancy''s Jack Ryan', 2018, NULL, 5, 1, NULL, 3, 2, 21, 60),
	('Swamp Thing', 2019, 2019, 5, 2, 1, 5, 1, 10, 60),
	('Cobra Kai', 2018, NULL, 5, 3, 1, 2, 3, 30, 30),
	('Perry Mason', 2020, NULL, 4, 1, NULL, 1, 1, 9, 60),
	('Unbelievable', 2019, 2019, 4, 1, NULL, 2, 1, 8, 50);

INSERT INTO na_biezaco VALUES
	(1),
	(3),
	(4);
	
INSERT INTO koniec VALUES
	(1),
	(3),
	(4);

INSERT INTO nie_skonczone VALUES
	(1),
	(5),
	(5);

INSERT INTO przerwa VALUES
	(2),
	(2),
	(5);
