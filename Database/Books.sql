USE [Library]
GO

/****** Object:  Table [dbo].[Books]    Script Date: 7/1/2022 4:43:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[ISBN_Code] [int] NOT NULL,
	[Book_Title] [varchar](100) NOT NULL,
	[Author] [varchar](100) NOT NULL,
	[Language] [varchar](10) NOT NULL,
	[Category_Name] [varchar](50) NOT NULL,
	[Publisher_id] [int] NOT NULL,
	[Publication_year] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publisher] FOREIGN KEY([Publisher_id])
REFERENCES [dbo].[Publisher] ([Publisher_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publisher]
GO

