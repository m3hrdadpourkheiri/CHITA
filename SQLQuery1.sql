--
-- File generated with SQLiteStudio v3.2.1 on Thu Aug 20 11:57:35 2020
--
-- Text encoding used: System
--
--PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: tblcash
DROP TABLE IF EXISTS tblcash;

CREATE TABLE tblcash (
    id   INTEGER      PRIMARY KEY ,
    name VARCHAR (50) NOT NULL
);





-- Table: tblcoach
DROP TABLE IF EXISTS tblcoach;

CREATE TABLE tblcoach (
    id            INTEGER      PRIMARY KEY ,
    code          VARCHAR (30),
    [name]         VARCHAR (30) NOT NULL,
    family        VARCHAR (30) NOT NULL,
    personalid    VARCHAR (20),
    nasionalid    VARCHAR (20),
    fathername    VARCHAR (20),
    birthdate     DATE,
    signupdate    DATE,
    gender        VARCHAR (4),
    marital       VARCHAR (6),
    mobilenumber  VARCHAR (13),
    insurancecode VARCHAR (20),
    sport         VARCHAR (20),
    licensenumber VARCHAR (20),
    [address]       TEXT,
    [description]   TEXT,
    picture       TEXT
);


-- Table: tblcost
DROP TABLE IF EXISTS tblcost;

CREATE TABLE tblcost (
    id   INTEGER      PRIMARY KEY ,
    [name] VARCHAR (50) NOT NULL
);


-- Table: tblcostpay
DROP TABLE IF EXISTS tblcostpay;

CREATE TABLE tblcostpay (
    id          INTEGER PRIMARY KEY ,
    costid      INTEGER  FOREIGN  key REFERENCES tblcost (id),
    cashid      INTEGER  FOREIGN  key REFERENCES tblcash (id),
    [date]        DATE,
    amount      INTEGER,
    [description] TEXT
);





-- Table: tblMember
DROP TABLE IF EXISTS tblMember;

CREATE TABLE tblMember (
    id            INTEGER      PRIMARY KEY ,
    code          INTEGER      NOT NULL,
    [name]          VARCHAR (30) NOT NULL,
    family        VARCHAR (30) NOT NULL,
    personalid    VARCHAR (20),
    nasionalid    VARCHAR (20),
    fathername    VARCHAR (20),
    birthdate     DATE,
    signupdate    DATE,
    gender        VARCHAR (4),
    marital       VARCHAR (6),
    mobilenumber  VARCHAR (13),
    insurancecode VARCHAR (20),
    coachid       INTEGER  FOREIGN  key    REFERENCES tblcoach (id),
    [address]       TEXT,
    [description]   TEXT,
    picture       TEXT
);

-- Table: tblcreadit
DROP TABLE IF EXISTS tblcreadit;

CREATE TABLE tblcreadit (
    id               INTEGER PRIMARY KEY ,
    memberid         INTEGER FOREIGN  key REFERENCES tblMember (id),
    remainingsession INTEGER,
    [expiredate]       DATE,
    freezcreadit     INTEGER
);



-- Table: tblcharge
DROP TABLE IF EXISTS tblcharge;

CREATE TABLE tblcharge (
    id              INTEGER               PRIMARY KEY ,
    memberid        INTEGER       FOREIGN  key        REFERENCES tblMember (id),
    [date]           DATE ,
    cashid          INTEGER,
    numberofsession INTEGER,
    [expiredate]      DATE
);


-- Table: tblpresence
DROP TABLE IF EXISTS tblpresence;

CREATE TABLE tblpresence (
    id       INTEGER  PRIMARY KEY ,
    memberid INTEGER FOREIGN  key REFERENCES tblMember (id),
    [datetime] DATETIME
);


-- Table: tblprofile
DROP TABLE IF EXISTS tblprofile;

CREATE TABLE tblprofile (
    id      INTEGER       PRIMARY KEY ,
    gymname VARCHAR (50),
    manager VARCHAR (30),
    [address] VARCHAR (100),
    logo    TEXT
);


-- Table: tblusers
DROP TABLE IF EXISTS tblusers;

CREATE TABLE tblusers (
    id         INTEGER      PRIMARY KEY,
    [name]       VARCHAR (30),
    family     VARCHAR (30),
    signupdate DATE,
    username   VARCHAR (30),
    [password]   VARCHAR (50),
    [status]     bit
);


COMMIT TRANSACTION;
--PRAGMA foreign_keys = on;
