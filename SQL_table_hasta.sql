USE [hastane]
GO

/****** Object:  Table [dbo].[hasta]    Script Date: 19.01.2023 13:02:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[hasta](
	[Id] [int] NULL,
	[isim] [varchar](50) NULL,
	[hastalýk türü] [varchar](50) NULL,
	[hastalýk detay] [varchar](50) NULL,
	[yatýþ tarihi] [varchar](50) NULL,
	[Cinsiyet] [varchar](50) NULL,
	[Yaþ] [int] NULL,
	[Taburcu Tarihi] [varchar](50) NULL,
	[Uygulanan Tedaviler] [varchar](50) NULL
) ON [PRIMARY]
GO


