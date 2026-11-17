CREATE DATABASE GYM;

USE GYM;

CREATE TABLE Members (
    MemberId INT IDENTITY(1,1) PRIMARY KEY,
    Rut VARCHAR(12) NOT NULL UNIQUE,
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NULL,
    RegisteredAt DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

CREATE TABLE Plans (
    PlanId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    DurationInDays INT NOT NULL, --30 para mensual, 90 trimestral, 365 anual etccc
    Price INT NOT NULL,
    IsActive BIT DEFAULT 1
);


CREATE TABLE Memberships (
    MembershipId INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT NOT NULL FOREIGN KEY REFERENCES Members(MemberId),
    PlanId INT NOT NULL FOREIGN KEY REFERENCES Plans(PlanId),
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    Status VARCHAR(20) DEFAULT 'VIGENTE' CHECK (Estado IN ('VIGENTE', 'VENCIDA', 'CANCELADA'))
);


CREATE TABLE Payments (
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,
    MembershipId INT NOT NULL FOREIGN KEY REFERENCES Memberships(MembershipId),
    Amount INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod VARCHAR(30) NOT NULL -- Efectivo, Transferencia, Tarjeta
);


CREATE TABLE Attendance (
    AttendanceId INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT NOT NULL FOREIGN KEY REFERENCES Members(MemberId),
    EntranceDateTime DATETIME DEFAULT GETDATE()
);
