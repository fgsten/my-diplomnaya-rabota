USE [Klevyy_Zana]
GO

/****** Object:  Table [dbo].[Provider]    Script Date: 24.05.2024 15:38:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Provider](
	[id_postavshchik] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Сity] [varchar](100) NULL,
	[number] [varchar](100) NULL,
 CONSTRAINT [PK_provider] PRIMARY KEY CLUSTERED 
(
	[id_postavshchik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

