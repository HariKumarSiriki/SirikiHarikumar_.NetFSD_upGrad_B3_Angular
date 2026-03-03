CREATE DATABASE EventDb;


USE EventDb;

CREATE TABLE UserInfo (
    EmailId VARCHAR(100) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    [Role] VARCHAR(20) NOT NULL CHECK (Role IN ('Admin','Participant')),
    [Password] VARCHAR(20) NOT NULL CHECK (LEN(Password) BETWEEN 6 AND 20)
);



SELECT EmailId, UserName,Role,Password FROM UserInfo;

CREATE TABLE EventDetails (
    EventId INT PRIMARY KEY ,
    EventName VARCHAR(50) NOT NULL,
    EventCategory VARCHAR(50) NOT NULL,
    EventDate DATETIME NOT NULL,
    [Description] VARCHAR(255),
    [Status] VARCHAR(20) NOT NULL CHECK (Status IN ('Active','In-Active'))
);

 

SELECT EventId,EventName, EventCategory,EventDate,Description,Status FROM EventDetails;
       


CREATE TABLE SpeakersDetails (
    SpeakerId INT PRIMARY KEY ,
    SpeakerName VARCHAR(50) NOT NULL
);



SELECT SpeakerId,SpeakerName FROM SpeakersDetails;

CREATE TABLE SessionInfo (
    SessionId INT IDENTITY(1,1) PRIMARY KEY ,
    EventId INT NOT NULL,
    SessionTitle VARCHAR(50) NOT NULL,
    SpeakerId INT NOT NULL,
    [Description] VARCHAR(255),
    SessionStart DATETIME NOT NULL,
    SessionEnd DATETIME NOT NULL,
    SessionUrl VARCHAR(255),

    FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    FOREIGN KEY (SpeakerId) REFERENCES SpeakersDetails(SpeakerId)
);


SELECT * FROM SessionInfo;


CREATE TABLE ParticipantEventDetails (
    Id INT PRIMARY KEY ,
    ParticipantEmailId VARCHAR(100) NOT NULL,
    EventId INT NOT NULL,
    SessionId INT NOT NULL,
    IsAttended BIT NOT NULL,

    FOREIGN KEY (ParticipantEmailId) REFERENCES UserInfo(EmailId),
    FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    FOREIGN KEY (SessionId) REFERENCES SessionInfo(SessionId)
);


SELECT * FROM ParticipantEventDetails;

