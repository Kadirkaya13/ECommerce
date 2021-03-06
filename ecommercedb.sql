USE [master]
GO
/****** Object:  Database [StoreDatabase]    Script Date: 27.06.2022 13:38:26 ******/
CREATE DATABASE [StoreDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StoreDatabase', FILENAME = N'C:\Users\kadir\StoreDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StoreDatabase_log', FILENAME = N'C:\Users\kadir\StoreDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StoreDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StoreDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StoreDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StoreDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StoreDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [StoreDatabase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StoreDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StoreDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StoreDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StoreDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StoreDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StoreDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StoreDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StoreDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StoreDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StoreDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StoreDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StoreDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StoreDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StoreDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StoreDatabase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [StoreDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StoreDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StoreDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [StoreDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StoreDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StoreDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StoreDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StoreDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StoreDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StoreDatabase] SET QUERY_STORE = OFF
GO
USE [StoreDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27.06.2022 13:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 27.06.2022 13:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27.06.2022 13:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
	[PictureUrl] [nvarchar](max) NULL,
	[ProductTypeId] [int] NULL,
	[BrandId] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 27.06.2022 13:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220520182106_StoreMigration', N'5.0.16')
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Id], [Name]) VALUES (1, N'MicroSoft')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (2, N'SpaceX')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (3, N'Nasa')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (4, N'Google')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (5, N'Twitter')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (6, N'Meta')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (7, N'Nintendo')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (8, N'Samsung')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [PictureUrl], [ProductTypeId], [BrandId]) VALUES (1, N'kalem', NULL, NULL, NULL, 2, 4)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [PictureUrl], [ProductTypeId], [BrandId]) VALUES (2, N'çorap', NULL, NULL, NULL, 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [PictureUrl], [ProductTypeId], [BrandId]) VALUES (3, N'laptop', NULL, NULL, NULL, 1, 3)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (1, N'Angular')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (2, N'React')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (3, N'TypeScript')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (4, N'JavaScript')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (5, N'Redis')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (6, N'MS Sql')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (7, N'HTML')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (8, N'XML')
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brand] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brand]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductType] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductType]
GO
USE [master]
GO
ALTER DATABASE [StoreDatabase] SET  READ_WRITE 
GO
