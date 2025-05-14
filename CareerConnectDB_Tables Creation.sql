CREATE DATABASE CareerConnectDB
USE CareerConnectDB

CREATE TABLE Users(
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(50) CHECK (Role IN ('Student', 'Recruiter', 'TPO', 'Coordinator')) NOT NULL,
    IsApproved BIT DEFAULT 0
);

-- COMPANIES Table
CREATE TABLE Companies (
    CompanyID INT IDENTITY(1,1) PRIMARY KEY,
    CompanyName VARCHAR(100) NOT NULL,
    Sector VARCHAR(100),
    Location VARCHAR(100)
);

-- STUDENTS Table
CREATE TABLE Students(
    StudentID INT PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    FAST_ID VARCHAR(20) UNIQUE NOT NULL,
    DegreeProgram VARCHAR(50) CHECK (DegreeProgram IN ('CS', 'SE', 'AI', 'DS')),
    CurrentSemester INT CHECK (CurrentSemester BETWEEN 1 AND 8),
    GPA FLOAT CHECK (GPA BETWEEN 0 AND 4.0)
);

-- RECRUITERS Table
CREATE TABLE Recruiters (
    RecruiterID INT PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    CompanyID INT FOREIGN KEY REFERENCES Companies(CompanyID)
);

-- JOB POSTINGS Table
CREATE TABLE JobPostings (
    JobID INT IDENTITY(1,1) PRIMARY KEY,
    CompanyID INT FOREIGN KEY REFERENCES Companies(CompanyID),
    JobTitle VARCHAR(100),
    JobType VARCHAR(50) CHECK (JobType IN ('Internship', 'Full-time')),
    SalaryRange VARCHAR(50),
    RequiredSkills TEXT,
    Description TEXT
);

-- JOB FAIR EVENTS Table
CREATE TABLE JobFairEvents (
    JobFairID INT IDENTITY(1,1) PRIMARY KEY,
    EventTitle VARCHAR(100),
    EventDate DATE,
    StartTime TIME,
    EndTime TIME,
    Venue VARCHAR(100)
);

-- APPLICATIONS Table
CREATE TABLE Applications (
    ApplicationID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    JobID INT FOREIGN KEY REFERENCES JobPostings(JobID),
    ApplicationStatus VARCHAR(50) CHECK (ApplicationStatus IN ('Pending', 'Shortlisted', 'Rejected', 'Offered', 'Accepted'))
);

-- INTERVIEWS Table
CREATE TABLE Interviews (
    InterviewID INT IDENTITY(1,1) PRIMARY KEY,
    ApplicationID INT FOREIGN KEY REFERENCES Applications(ApplicationID),
    InterviewDate DATE,
    StartTime TIME,
    EndTime TIME,
    InterviewResult VARCHAR(100)
);

-- REVIEWS Table
CREATE TABLE Reviews (
    ReviewID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    RecruiterID INT FOREIGN KEY REFERENCES Recruiters(RecruiterID),
    InterviewID INT FOREIGN KEY REFERENCES Interviews(InterviewID),
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    Comments TEXT
);

-- BOOTH COORDINATORS Table
CREATE TABLE BoothCoordinators (
    CoordinatorID INT PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    AssignedFairID INT FOREIGN KEY REFERENCES JobFairEvents(JobFairID)
);

-- BOOTH VISITS Table (optional for analytics)
CREATE TABLE BoothVisits (
    VisitID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    CompanyID INT FOREIGN KEY REFERENCES Companies(CompanyID),
    JobFairID INT FOREIGN KEY REFERENCES JobFairEvents(JobFairID),
    CheckInTime DATETIME
);

CREATE TABLE Skills (
    SkillID INT IDENTITY(1,1) PRIMARY KEY,
    SkillName VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE StudentSkills (
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    SkillID INT FOREIGN KEY REFERENCES Skills(SkillID),
    PRIMARY KEY (StudentID, SkillID)
);

CREATE TABLE Certifications (
    CertID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    Title VARCHAR(100) NOT NULL,
    IssuedBy VARCHAR(100),
    IssueDate DATE
);

