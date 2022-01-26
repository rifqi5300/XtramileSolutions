USE [master]
GO

/****** Object:  Database [XtramileSolutions]    Script Date: 26/01/2022 18:06:21 ******/
CREATE DATABASE [XtramileSolutions]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'XtramileSolutions', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\XtramileSolutions.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'XtramileSolutions_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\XtramileSolutions_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [XtramileSolutions].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [XtramileSolutions] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [XtramileSolutions] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [XtramileSolutions] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [XtramileSolutions] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [XtramileSolutions] SET ARITHABORT OFF 
GO

ALTER DATABASE [XtramileSolutions] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [XtramileSolutions] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [XtramileSolutions] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [XtramileSolutions] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [XtramileSolutions] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [XtramileSolutions] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [XtramileSolutions] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [XtramileSolutions] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [XtramileSolutions] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [XtramileSolutions] SET  DISABLE_BROKER 
GO

ALTER DATABASE [XtramileSolutions] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [XtramileSolutions] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [XtramileSolutions] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [XtramileSolutions] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [XtramileSolutions] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [XtramileSolutions] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [XtramileSolutions] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [XtramileSolutions] SET RECOVERY FULL 
GO

ALTER DATABASE [XtramileSolutions] SET  MULTI_USER 
GO

ALTER DATABASE [XtramileSolutions] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [XtramileSolutions] SET DB_CHAINING OFF 
GO

ALTER DATABASE [XtramileSolutions] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [XtramileSolutions] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [XtramileSolutions] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [XtramileSolutions] SET QUERY_STORE = OFF
GO

ALTER DATABASE [XtramileSolutions] SET  READ_WRITE 
GO






USE [XtramileSolutions]
GO

/****** Object:  Table [dbo].[Countries]    Script Date: 26/01/2022 18:08:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Countries](
	[CountryName] [varchar](50) NULL
) ON [PRIMARY]
GO





USE [XtramileSolutions]
GO

/****** Object:  Table [dbo].[Cities]    Script Date: 26/01/2022 18:08:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cities](
	[CityName] [varchar](50) NULL,
	[CountryName] [varchar](50) NULL
) ON [PRIMARY]
GO




USE [XtramileSolutions]
GO

INSERT INTO [dbo].[Countries]
           ([CountryName])
     VALUES
           ('Indonesia')
		   
INSERT INTO [dbo].[Countries]
           ([CountryName])
     VALUES
           ('United Kingdom')		   
GO



USE [XtramileSolutions]
GO

INSERT INTO [dbo].[Cities]
           ([CityName]
           ,[CountryName])
     VALUES
           ('London'
           ,'United Kingdom')
INSERT INTO [dbo].[Cities]
           ([CityName]
           ,[CountryName])
     VALUES
           ('London'
           ,'Derry')
INSERT INTO [dbo].[Cities]
           ([CityName]
           ,[CountryName])
     VALUES
           ('Londesborough'
           ,'United Kingdom')
INSERT INTO [dbo].[Cities]
           ([CityName]
           ,[CountryName])
     VALUES
           ('Loftus'
           ,'United Kingdom')
INSERT INTO [dbo].[Cities]
           ([CityName]
           ,[CountryName])
     VALUES
           ('Medan'
           ,'Indonesia')
INSERT INTO [dbo].[Cities]
           ([CityName]
           ,[CountryName])
     VALUES
           ('Depok'
           ,'Indonesia')		   
GO







