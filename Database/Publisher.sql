USE [Library]
GO

/****** Object:  Table [dbo].[Publisher]    Script Date: 7/1/2022 4:43:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Publisher](
	[Publisher_id] [int] NOT NULL,
	[Publisher_Name] [varchar](100) NOT NULL,
	[Publisher_Address] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Publisher_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

