
Create database Map
GO
USE [Map]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buildings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [varchar](50) NULL,
	[X] [real] NOT NULL,
	[Y] [real] NOT NULL,
	[rotation] [real] NOT NULL,
	[Width] [real] NOT NULL,
	[Length] [real] NOT NULL,
 CONSTRAINT [PK_Buildings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PointsStreet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[X] [real] NOT NULL,
	[Y] [real] NOT NULL,
	[Order] [int] NOT NULL,
	[IdStreet] [int] NOT NULL,
 CONSTRAINT [PK_PointsStreet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Streets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Streets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Buildings] ON 

INSERT [dbo].[Buildings] ([Id], [Number], [X], [Y], [rotation], [Width], [Length]) VALUES (1, N'20', 90, 550, 20, 40, 200)
INSERT [dbo].[Buildings] ([Id], [Number], [X], [Y], [rotation], [Width], [Length]) VALUES (2, N'22', 90, 450, 20, 350, 100)
SET IDENTITY_INSERT [dbo].[Buildings] OFF
SET IDENTITY_INSERT [dbo].[PointsStreet] ON 

INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (1, 120, 100, 1, 1)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (2, 300, 100, 2, 1)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (3, 450, 120, 3, 1)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (4, 100, 0, 1, 2)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (5, 100, 350, 2, 2)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (6, 90, 450, 3, 2)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (7, 90, 550, 4, 2)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (8, 200, 560, 5, 2)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (9, 100, 500, 1, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (10, 816, 500, 2, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (11, 994, 400, 3, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (12, 1022, 404, 4, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (13, 968, 513, 5, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (14, 1037, 614, 6, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (15, 1104, 637, 7, 4)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (17, 120, 300, 1, 3)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (18, 300, 300, 2, 3)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (19, 450, 340, 3, 3)
INSERT [dbo].[PointsStreet] ([Id], [X], [Y], [Order], [IdStreet]) VALUES (20, 590, 320, 4, 3)
SET IDENTITY_INSERT [dbo].[PointsStreet] OFF
SET IDENTITY_INSERT [dbo].[Streets] ON 

INSERT [dbo].[Streets] ([Id], [Name]) VALUES (1, N'Odkryta')
INSERT [dbo].[Streets] ([Id], [Name]) VALUES (2, N'Nowodworska')
INSERT [dbo].[Streets] ([Id], [Name]) VALUES (3, N'Mehoferra')
INSERT [dbo].[Streets] ([Id], [Name]) VALUES (4, N'Stefanika')
SET IDENTITY_INSERT [dbo].[Streets] OFF
ALTER TABLE [dbo].[PointsStreet]  WITH CHECK ADD  CONSTRAINT [FK_PointsStreet_Streets] FOREIGN KEY([IdStreet])
REFERENCES [dbo].[Streets] ([Id])
GO
ALTER TABLE [dbo].[PointsStreet] CHECK CONSTRAINT [FK_PointsStreet_Streets]
GO
