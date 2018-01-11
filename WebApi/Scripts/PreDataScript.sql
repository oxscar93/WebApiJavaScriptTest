CREATE DATABASE Users

GO
USE [Users]

EXEC ('CREATE SCHEMA [usr]')

GO

CREATE TABLE [usr].[User] (

	UserId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(50) NOT NULL,
    FirstName varchar(50) NOT NULL,
    Email varchar(50) NOT NULL,
    UserPassword varchar(50) NOT NULL 
)

USE [Users]

GO

INSERT INTO [usr].[User]
     VALUES
           ('Jose', 
		   'Robert',
		   'robert@gmail.com', 
		   '1234')
          
GO

INSERT INTO [usr].[User]
     VALUES
           ('Alberto', 
		   'Robert',
		   'alberto@gmail.com', 
		   '12345')
          
GO

INSERT INTO [usr].[User]
     VALUES
           ('Jose', 
		   'Carlos',
		   'carlos@gmail.com', 
		   '1234333')
          
GO

INSERT INTO [usr].[User]
     VALUES
           ('Jose', 
		   'Alfonso',
		   'alfonso@gmail.com', 
		   '1234676767')
          



