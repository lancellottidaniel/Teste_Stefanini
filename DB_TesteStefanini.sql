USE [master]
GO
/****** Object:  Database [Teste_Stefanini]    Script Date: 16/12/2018 15:18:10 ******/
CREATE DATABASE [Teste_Stefanini]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Teste_Stefanini', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Teste_Stefanini.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Teste_Stefanini_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Teste_Stefanini_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Teste_Stefanini] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Teste_Stefanini].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Teste_Stefanini] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET ARITHABORT OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Teste_Stefanini] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Teste_Stefanini] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Teste_Stefanini] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Teste_Stefanini] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Teste_Stefanini] SET  MULTI_USER 
GO
ALTER DATABASE [Teste_Stefanini] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Teste_Stefanini] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Teste_Stefanini] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Teste_Stefanini] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Teste_Stefanini] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Teste_Stefanini] SET QUERY_STORE = OFF
GO
USE [Teste_Stefanini]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Teste_Stefanini]
GO
/****** Object:  User [dlancellotti]    Script Date: 16/12/2018 15:18:10 ******/
CREATE USER [dlancellotti] FOR LOGIN [dlancellotti] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[TabPessoa]    Script Date: 16/12/2018 15:18:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabPessoa](
	[codigo] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sobrenome] [varchar](50) NOT NULL,
	[data_nasc] [date] NOT NULL,
	[sexo] [varchar](20) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[ativo] [varchar](5) NOT NULL,
 CONSTRAINT [PK_TabPessoa] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabProduto]    Script Date: 16/12/2018 15:18:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabProduto](
	[codigo] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[produto] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Teste_Stefanini] SET  READ_WRITE 
GO
