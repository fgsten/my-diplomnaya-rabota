USE [Klevyy_Zana]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 24.05.2024 15:37:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[id_tovar] [int] IDENTITY(1,1) NOT NULL,
	[Name of product] [varchar](150) NULL,
	[Tip tovara] [varchar](50) NULL,
	[Kolichestvo na sklade] [int] NULL,
	[Prikhodnaya summa] [int] NULL,
	[Protsent natsenki] [int] NULL,
	[Roznichnaya summa] [int] NULL,
	[id_postavshchik] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id_tovar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider] FOREIGN KEY([id_postavshchik])
REFERENCES [dbo].[Provider] ([id_postavshchik])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Provider]
GO

