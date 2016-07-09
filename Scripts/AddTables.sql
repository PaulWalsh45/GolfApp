

CREATE TABLE Player
(
PlayerId int IDENTITY NOT NULL PRIMARY KEY,
PlayerFirstName varchar(100),
PlayerLastName varchar(100),
PlayerHandicap integer,
PlayerAdjust integer,
PlayerAddress varchar(100),
PlayerPhone varchar(100),
PlayerEmail varchar (100),
PlayerClub varchar(100),
PlayerImage varchar (100),
);


CREATE TABLE Course
(
CourseId int IDENTITY NOT NULL PRIMARY KEY,
CourseName varchar(100),
CourseAddress varchar(100),
CoursePars varchar(100),
CourseIndexs varchar(100)
);


CREATE TABLE Outing
(
OutingId int IDENTITY NOT NULL PRIMARY KEY,
OutingDate date (100),
FOREIGN KEY (CourseId)REFERENCES Course (CourseId)
FOREIGN KEY (PlayerId)REFERENCES Player (PlayerId)
);


 CREATE TABLE Question 
(
QuestionId int IDENTITY NOT NULL PRIMARY KEY,
QuestionText varchar(100),
FOREIGN KEY (QuizId)REFERENCES Quiz (QuizId)
);


CREATE TABLE Answer
(
AnswerId int IDENTITY NOT NULL PRIMARY KEY,
AnswerText varchar(100),
FOREIGN KEY (QuestionId) REFERENCES Question (QuestionId)
);

,



 




