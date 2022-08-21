USE [Library]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 7/1/2022 4:43:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[Student_Id] [int] NOT NULL,
	[Student_Name] [varchar](50) NOT NULL,
	[Sex] [varchar](20) NOT NULL,
	[Date_Of_Birth] [date] NOT NULL,
	[Department] [varchar](10) NOT NULL,
	[Course] [varchar](50) NOT NULL,
	[Semester] [int] NOT NULL,
	[contact_Number] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Student_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

