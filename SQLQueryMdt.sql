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

--2. Medications Table
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

--3. MedicationSchedules Table
   CREATE TABLE MedicationSchedules (
       ScheduleID INT PRIMARY KEY IDENTITY(1,1),
       MedicationID INT FOREIGN KEY REFERENCES Medications(MedicationID),
       ScheduledTime DATETIME NOT NULL,
       Status NVARCHAR(20) DEFAULT 'Pending',  -- e.g., 'Pending', 'Taken', 'Missed'
       CreatedAt DATETIME DEFAULT GETDATE()
   );
--4. CheckIns Table
   CREATE TABLE CheckIns (
       CheckInID INT PRIMARY KEY IDENTITY(1,1),
       ScheduleID INT FOREIGN KEY REFERENCES MedicationSchedules(ScheduleID),
       CheckInTime DATETIME NOT NULL,
       AdherenceStatus NVARCHAR(20) NOT NULL,  -- e.g., 'Taken', 'Missed'
       SideEffects NVARCHAR(MAX),
       CreatedAt DATETIME DEFAULT GETDATE()
   );

--5. Reminders Table
   CREATE TABLE Reminders (
       ReminderID INT PRIMARY KEY IDENTITY(1,1),
       UserID INT FOREIGN KEY REFERENCES Users(UserID),
       ScheduleID INT FOREIGN KEY REFERENCES MedicationSchedules(ScheduleID),
       ReminderTime DATETIME NOT NULL,
       Message NVARCHAR(255) NOT NULL,
       Status NVARCHAR(20) DEFAULT 'Sent',  -- e.g., 'Sent', 'Delivered', 'Read'
       CreatedAt DATETIME DEFAULT GETDATE()
   );

--6. Notifications Table
   CREATE TABLE Notifications (
       NotificationID INT PRIMARY KEY IDENTITY(1,1),
       UserID INT FOREIGN KEY REFERENCES Users(UserID),
       NotificationType NVARCHAR(50) NOT NULL,  -- e.g., 'Adherence Report', 'Message from Doctor'
       Message NVARCHAR(MAX) NOT NULL,
       SentAt DATETIME DEFAULT GETDATE(),
       Status NVARCHAR(20) DEFAULT 'Unread'  -- e.g., 'Unread', 'Read'
   );

--7. Goals Table (Optional)
   CREATE TABLE Goals (
       GoalID INT PRIMARY KEY IDENTITY(1,1),
       UserID INT FOREIGN KEY REFERENCES Users(UserID),
       GoalType NVARCHAR(100) NOT NULL,  -- e.g., 'Adherence Goal'
       TargetValue INT NOT NULL,  -- e.g., 90% adherence target
       StartDate DATE NOT NULL,
       EndDate DATE,
       Status NVARCHAR(20) DEFAULT 'Active',  -- e.g., 'Active', 'Achieved'
       CreatedAt DATETIME DEFAULT GETDATE(),
       UpdatedAt DATETIME
   );

--8. Doctors Table (Optional)
   CREATE TABLE Doctors (
       DoctorID INT PRIMARY KEY IDENTITY(1,1),
       Name NVARCHAR(100) NOT NULL,
       Specialization NVARCHAR(100),
       ContactInfo NVARCHAR(255),
       CreatedAt DATETIME DEFAULT GETDATE(),
       UpdatedAt DATETIME
   );

--9. Doctor_Patient Table (Optional)
   CREATE TABLE Doctor_Patient (
       DoctorPatientID INT PRIMARY KEY IDENTITY(1,1),
       DoctorID INT FOREIGN KEY REFERENCES Doctors(DoctorID),
       UserID INT FOREIGN KEY REFERENCES Users(UserID),
       AssignedAt DATETIME DEFAULT GETDATE()
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