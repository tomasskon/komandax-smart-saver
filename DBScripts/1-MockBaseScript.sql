CREATE TABLE [dbo].[Transactions](
	[Id] [uniqueidentifier] NOT NULL,
	[Amount] [int] NOT NULL,
	[Description] [nvarchar](50) NULL,
	[UserId] [uniqueidentifier] NOT NULL
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Id]  DEFAULT (newsequentialid()) FOR [Id]
GO

CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Gmail] [nvarchar](50) NOT NULL,
	[Cash] [float] NOT NULL,
	[Card] [float] NOT NULL,
	[UserImage] [image] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Id]  DEFAULT (newsequentialid()) FOR [Id]
GO

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO

INSERT INTO [Users] ([Id], [FullName], [Gmail]) VALUES ('6e33fa08-bc0f-438c-a21b-bcf4fc227661', 'Test Testington', 'test@gmail.com')
GO

INSERT INTO [Transactions] ([Amount], [Description], [UserId]) VALUES (5, 'Buying Coffee', '6e33fa08-bc0f-438c-a21b-bcf4fc227661')
GO

INSERT INTO [Transactions] ([Amount], [Description], [UserId]) VALUES (7, 'Buying Pizza', '6e33fa08-bc0f-438c-a21b-bcf4fc227661')
GO