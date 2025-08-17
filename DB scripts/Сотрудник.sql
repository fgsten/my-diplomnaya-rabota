USE [Klevyy_Zana]
GO

/****** Object:  Table [dbo].[Еmployees]    Script Date: 24.05.2024 15:38:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Еmployees](
	[id_sotrudnik] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [varchar](150) NULL,
	[dolzhnost] [varchar](50) NULL,
	[login] [varchar](25) NULL,
	[password] [varchar](25) NULL,
	[is_admin] [bit] NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[id_sotrudnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

