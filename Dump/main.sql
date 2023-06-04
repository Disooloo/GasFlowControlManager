-- Создание таблицы "GasCompressors"
CREATE TABLE GasCompressors (
    Id INT PRIMARY KEY,
    Name VARCHAR(255),
    Manufacturer VARCHAR(255),
    MaxPressure DECIMAL(10, 2),
    MaxFlowRate DECIMAL(10, 2),
    Efficiency DECIMAL(5, 2),
    InstallationDate DATE
);

-- Создание таблицы "Parameters"
CREATE TABLE Parameters (
    Id INT PRIMARY KEY,
    GasCompressorId INT,
    ParameterName VARCHAR(255),
    ParameterValue DECIMAL(10, 2),
    FOREIGN KEY (GasCompressorId) REFERENCES GasCompressors(Id)
);

-- Создание таблицы "States"
CREATE TABLE States (
    Id INT PRIMARY KEY,
    GasCompressorId INT,
    StateName VARCHAR(255),
    StartDateTime DATETIME,
    EndDateTime DATETIME,
    FOREIGN KEY (GasCompressorId) REFERENCES GasCompressors(Id)
);

-- Создание таблицы "Пользователи"
CREATE TABLE Users (
    Id INT PRIMARY KEY,
    FullName VARCHAR(255),
    Position VARCHAR(255),
    Login VARCHAR(255),
    Password VARCHAR(255),
    IsAdmin BIT,
    RegistrationDate DATE,
    LastLoginDate DATETIME
);

-- Вставка тестовых данных для таблицы "GasCompressors"
INSERT INTO GasCompressors (Id, Name, Manufacturer, MaxPressure, MaxFlowRate, Efficiency, InstallationDate)
VALUES
    (1, 'Compressor 1', 'Manufacturer 1', 100.00, 50.00, 0.95, '2022-01-01'),
    (2, 'Compressor 2', 'Manufacturer 2', 150.00, 75.00, 0.90, '2022-02-01');

-- Вставка тестовых данных для таблицы "Parameters"
INSERT INTO Parameters (Id, GasCompressorId, ParameterName, ParameterValue)
VALUES
    (1, 1, 'Parameter 1', 10.00),
    (2, 1, 'Parameter 2', 20.00),
    (3, 2, 'Parameter 1', 15.00),
    (4, 2, 'Parameter 2', 25.00);

-- Вставка тестовых данных для таблицы "States"
INSERT INTO States (Id, GasCompressorId, StateName, StartDateTime, EndDateTime)
VALUES
    (1, 1, 'State 1', '2022-01-01 10:00:00', '2022-01-01 11:00:00'),
    (2, 1, 'State 2', '2022-01-01 12:00:00', '2022-01-01 13:00:00'),
    (3, 2, 'State 1', '2022-02-01 10:00:00', '2022-02-01 11:00:00'),
    (4, 2, 'State 2', '2022-02-01 12:00:00', '2022-02-01 13:00:00');

-- Вставка тестовых данных для таблицы "Пользователи"
INSERT INTO Users (Id, FullName, Position, Login, Password, IsAdmin, RegistrationDate, LastLoginDate)
VALUES
    (1, 'John Smith', 'Manager', 'john', 'password123', 1, '2022-01-01', '2022-01-01 10:00:00'),
    (2, 'Jane Doe', 'Engineer', 'jane', 'password456', 0, '2022-02-01', '2022-02-01 12:00:00');

ALTER TABLE GasCompressors
ADD CurrentFlowRate DECIMAL(10, 2),
    CurrentPressure DECIMAL(10, 2),
    CurrentEfficiency DECIMAL(5, 2);

-- Вставка данных для новых столбцов
UPDATE GasCompressors
SET CurrentFlowRate = 50.00,
    CurrentPressure = 100.00,
    CurrentEfficiency = 0.95
WHERE Id = 1;

UPDATE GasCompressors
SET CurrentFlowRate = 75.00,
    CurrentPressure = 150.00,
    CurrentEfficiency = 0.90
WHERE Id = 2;
