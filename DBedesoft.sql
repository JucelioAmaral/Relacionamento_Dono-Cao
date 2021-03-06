Create Database ProvaEdsesoft
go

USE [ProvaEdsesoft]
GO
/****** Object:  Table [dbo].[tblDono_Cao]    Script Date: 4/26/2021 9:50:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDono_Cao]') AND type in (N'U'))
DROP TABLE [dbo].[tblDono_Cao]
GO
/****** Object:  Table [dbo].[tblDono]    Script Date: 4/26/2021 9:50:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDono]') AND type in (N'U'))
DROP TABLE [dbo].[tblDono]
GO
/****** Object:  Table [dbo].[tblCao]    Script Date: 4/26/2021 9:50:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCao]') AND type in (N'U'))
DROP TABLE [dbo].[tblCao]
GO
/****** Object:  Table [dbo].[tblCao]    Script Date: 4/26/2021 9:50:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCao](
	[IdCao] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Raca] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDono]    Script Date: 4/26/2021 9:50:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDono](
	[IdDono] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDono_Cao]    Script Date: 4/26/2021 9:50:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDono_Cao](
	[IdDono] [int] NOT NULL,
	[IdCao] [int] NOT NULL
) ON [PRIMARY]
GO
