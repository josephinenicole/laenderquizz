CREATE DATABASE laenderquiz;

CREATE TABLE Länder (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Hauptstadt VARCHAR(255) NOT NULL,
    Bilddatei VARCHAR(255) NOT NULL
);



INSERT INTO Länder (Name, Hauptstadt, Bilddatei) VALUES
('Deutschland', 'Berlin', 'pfad_zu_deutschland_flagge'),
('Frankreich', 'Paris', 'pfad_zu_frankreich_flagge'),
('Italien', 'Rom', 'pfad_zu_italien_flagge'),
('Spanien', 'Madrid', 'pfad_zu_spanien_flagge.webp'),
('USA', 'Washington, D.C.', 'pfad_zu_usa_flagge.webp'),
('China', 'Peking', 'pfad_zu_china_flagge.webp'),
('Brasilien', 'Brasília', 'pfad_zu_brasilien_flagge.png'),
('Indien', 'Neu-Delhi', 'pfad_zu_indien_flagge.png'),
('Russland', 'Moskau', 'pfad_zu_russland_flagge.webp'),
('Ägypten', 'Kairo', 'pfad_zu_aegypten_flagge.webp');



CREATE TABLE Highscore (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    SpielerName VARCHAR(255),
    Punktzahl INT,
    Datum DATETIME
);
