CREATE TABLE [dbo].[Goals](
	[Id] [uniqueidentifier] NOT NULL,
	[GoalName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[GoalAmount] [float] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[FinishDate] [datetime] NOT NULL,
	[Progress] [float] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SavingGoals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Goals] ADD  CONSTRAINT [DF_Goals_Id]  DEFAULT (newsequentialid()) FOR [Id]
GO

ALTER TABLE [dbo].[Goals]  WITH CHECK ADD  CONSTRAINT [FK_Goals_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO