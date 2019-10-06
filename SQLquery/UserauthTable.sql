
USE [UserAuthentication]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2019-10-05 10:06:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [varchar](50) NOT NULL,
	[passsword] [varchar](50) NOT NULL,
	[UseraccessId] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[Userauth]    Script Date: 2019-10-06 8:58:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Userauth](
	[UseraccessId] [nvarchar](50) NOT NULL,
	[AccessCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Userauth] PRIMARY KEY CLUSTERED 
(
	[UseraccessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



