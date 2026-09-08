create database QRLibrary;
use QRLibrary;

CREATE TABLE Students
(
    StudentID INT AUTO_INCREMENT PRIMARY KEY,
    UniversityID VARCHAR(50) UNIQUE,
    StudentName VARCHAR(100),
    Password VARCHAR(100),
    Status VARCHAR(20)
);

INSERT INTO Students
(UniversityID,StudentName,Password,Status)
VALUES
('2023-CS-101','Ahmad','123','Active'),
('2024-CS-201','Ahmad','123','Active'),
('2025-CS-102','Ahmad','123','Active');

CREATE TABLE Books
(
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    BookCode VARCHAR(50) UNIQUE,
    BookTitle VARCHAR(200),
    Author VARCHAR(100)
);

INSERT INTO Books
(BookCode,BookTitle,Author)
VALUES
('BOOK001','Database Systems','Korth');

CREATE TABLE Transactions
(
    TransactionID VARCHAR(50) PRIMARY KEY,
    StudentID INT,
    BookID INT,
    IssueDate DATE,
    DueDate DATE,
    Status VARCHAR(20),

    FOREIGN KEY(StudentID)
    REFERENCES Students(StudentID),

    FOREIGN KEY(BookID)
    REFERENCES Books(BookID)
);
SELECT * FROM Books;
SELECT * FROM Students;
SELECT * FROM Transactions;

ALTER TABLE Transactions
ADD ReturnDate DATE NULL;

ALTER TABLE Transactions
ADD FineAmount DECIMAL(10,2)
DEFAULT 0;

DESC Transactions;

UPDATE Transactions
SET DueDate = '2026-06-01'
WHERE TransactionID = 'TRX639171528424339817';

ALTER TABLE Students
ADD Role VARCHAR(20) DEFAULT 'Student';

UPDATE Students
SET Role='Student';

set sql_safe_updates=0;

INSERT INTO Students
(UniversityID,StudentName,Password,Status,Role)
VALUES
('ADMIN001','Library Admin','admin123','Active','Admin');

SELECT * FROM Students;

CREATE TABLE ActivityLogs
(
    LogID INT AUTO_INCREMENT PRIMARY KEY,

    StudentID INT,

    ActionType VARCHAR(50),

    ActionDescription VARCHAR(255),

    ActionTime DATETIME,

    FOREIGN KEY(StudentID)
    REFERENCES Students(StudentID)
);

SELECT * FROM ActivityLogs;

SELECT *
FROM ActivityLogs
ORDER BY LogID DESC;

ALTER TABLE Students
ADD Department VARCHAR(50);

ALTER TABLE Students
ADD Semester INT;

UPDATE Students
SET Department='Computer Science',
Semester=5
WHERE StudentID=1;

UPDATE Students
SET Department='Software Engineering',
Semester=4
WHERE StudentID=5;

UPDATE Students
SET Department='Computer Science',
Semester=6
WHERE StudentID=6;

SELECT
StudentName,
Department,
Semester
FROM Students;

ALTER TABLE Books
ADD Category VARCHAR(50);

UPDATE Books
SET Category='Computer Science'
WHERE BookID=1;

UPDATE Books
SET Category='Computer Science'
WHERE BookID=2;

UPDATE Books
SET Category='Software Engineering'
WHERE BookID=3;

UPDATE Books
SET Category='Database'
WHERE BookID=4;

SELECT
BookTitle,
Category
FROM Books;

ALTER TABLE Books
ADD BranchName VARCHAR(50);

UPDATE Books
SET BranchName='Main Library'
WHERE BookID=1;

UPDATE Books
SET BranchName='Computer Science Library'
WHERE BookID=2;

UPDATE Books
SET BranchName='Engineering Library'
WHERE BookID=3;

SELECT
BookID,
BookTitle,
BranchName
FROM Books;

SELECT StudentID,
UniversityID,
Password
FROM Students;

SELECT *
FROM ActivityLogs
ORDER BY LogID DESC;

DESCRIBE ActivityLogs;

CREATE TABLE ArchivedTransactions
(
    ArchiveID INT AUTO_INCREMENT PRIMARY KEY,

    TransactionID VARCHAR(50),

    StudentID INT,

    BookID INT,

    IssueDate DATE,

    DueDate DATE,

    ReturnDate DATE,

    FineAmount DECIMAL(10,2),

    Status VARCHAR(50),

    ArchivedOn DATETIME
);

SELECT * FROM ArchivedTransactions;