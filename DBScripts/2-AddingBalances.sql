CREATE TABLE [dbo].[Balances](
    [Id] [uniqueidentifier] NOT NULL,
    [Cash] [float] NULL,
    [Card] [float] NULL,
    [UserId] [uniqueidentifier] NOT NULL
 CONSTRAINT [PK_Balances] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Balances] ADD  CONSTRAINT [DF_Balances_Id]  DEFAULT (newsequentialid()) FOR [Id]
GO

ALTER TABLE [dbo].[Balances]  WITH CHECK ADD  CONSTRAINT [FK_Balances_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO