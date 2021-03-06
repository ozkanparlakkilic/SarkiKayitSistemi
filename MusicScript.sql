USE [Music]
GO
/****** Object:  Table [dbo].[Albums]    Script Date: 25.06.2021 04:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Albums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SongName] [nvarchar](50) NULL,
	[AlbumName] [nvarchar](50) NULL,
	[ReleaseYear] [nvarchar](50) NULL,
	[Singer] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_ALBUM] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Albums] ON 

INSERT [dbo].[Albums] ([Id], [SongName], [AlbumName], [ReleaseYear], [Singer], [Type]) VALUES (1, N'Tarkan', N'Dudu', N'2003', N'Tarkan', N'Pop')
INSERT [dbo].[Albums] ([Id], [SongName], [AlbumName], [ReleaseYear], [Singer], [Type]) VALUES (2, N'Aya Benzer', N'Aşka Yürek Gerek', N'2013', N'Mustafa Sandal', N'Pop')
INSERT [dbo].[Albums] ([Id], [SongName], [AlbumName], [ReleaseYear], [Singer], [Type]) VALUES (3, N'Fırtınam', N'Sakin Olmam Lazım', N'2006', N'Hayko Cepkin', N'Rock')
SET IDENTITY_INSERT [dbo].[Albums] OFF
GO
