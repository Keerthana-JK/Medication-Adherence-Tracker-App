create database Mdt;
use Mdt;

--CREATE TABLES
--1. Users Table
 CREATE TABLE Users (
       UserID INT PRIMARY KEY IDENTITY(1,1),
       Name NVARCHAR(100) NOT NULL,
       Email NVARCHAR(100) UNIQUE NOT NULL,
       PasswordHash NVARCHAR(256) NOT NULL,
       DateOfBirth DATE,
       MedicalHistory NVARCHAR(MAX),
       CreatedAt DATETIME DEFAULT GETDATE(),
       UpdatedAt DATETIME
   );

CREATE TABLE Medications (
       MedicationID INT PRIMARY KEY IDENTITY(1,1),
       UserID INT FOREIGN KEY REFERENCES Users(UserID),
       MedicationName NVARCHAR(100) NOT NULL,
       Dosage NVARCHAR(50) NOT NULL,
       Frequency NVARCHAR(50) NOT NULL,  -- e.g., 'Once a day', 'Twice a day'
       StartDate DATE NOT NULL,
       EndDate DATE,
       CreatedAt DATETIME DEFAULT GETDATE(),
       UpdatedAt DATETIME
   );

--INSERT QUERIES

--Users Table
INSERT INTO Users (Name, Email, PasswordHash, DateOfBirth, MedicalHistory)
VALUES
    ('Ash', 'john.doe@example.com', 'password123', '1990-01-01', 'Hypertension, Diabetes'),
    ('Kit', 'jane.smith@example.com', 'password456', '1995-06-15', 'Asthma, Allergies'),
    ('Col', 'bob.johnson@example.com', 'password789', '1980-03-20', 'High Cholesterol, Heart Disease'),
    ('Ash', 'alice.brown@example.com', 'password101', '1992-09-10', 'None'),
    ('Kit', 'mike.davis@example.com', 'password202', '1985-02-25', 'Gout, Arthritis');

--Medications Table
insert into Medications (UserID, MedicationName, Dosage, Frequency, StartDate, EndDate) values
(1, 'Acetaminophen', '500mg', 'Twice a day', '2022-01-01', '2022-01-31'),
(1, 'Ibuprofen', '200mg', 'Once a day', '2022-02-01', '2022-02-28'),
(2, 'Aspirin', '81mg', 'Once a day', '2022-03-01', '2022-03-31'),
(3, 'Lisinopril', '10mg', 'Once a day', '2022-04-01', '2022-04-30'),
(2, 'Metformin', '500mg', 'Twice a day', '2022-05-01', '2022-05-31'),
(3, 'Fluticasone', '220mcg', 'Twice a day', '2022-10-01', '2022-10-31');
select * from Medications;