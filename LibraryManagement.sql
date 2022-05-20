CREATE DATABASE LIBRARY_MANAGEMENT

USE LIBRARY_MANAGEMENT

CREATE TABLE USERS(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FIRSTNAME VARCHAR(20) NOT NULL,
	LASTNAME VARCHAR(20) NOT NULL,
	USERNAME VARCHAR(30) NOT NULL,
	USERPASSWORD VARCHAR(30) NOT NULL,
	USERTYPE VARCHAR(20) NOT NULL
)

INSERT INTO USERS VALUES('PHAN', 'LAM', 'LAMPHAN', '123456', 'Quan tri vien')
INSERT INTO USERS VALUES('NGUYEN', 'DOAN', 'DOANNGUYEN', '123456', 'Quan tri vien')
INSERT INTO USERS VALUES('NGUYEN', 'HUY', 'HUYNGUYEN', '123456', 'Quan tri vien')

SELECT * FROM USERS

CREATE TABLE GENRES(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NAME VARCHAR(120) NOT NULL
)

drop table GENRES

INSERT INTO GENRES VALUES('Trinh tham')
INSERT INTO GENRES VALUES('Kinh di')
SELECT * FROM GENRES
SELECT NAME FROM GENRES WHERE NAME = 'Kinh di'	
DELETE FROM GENRES 
