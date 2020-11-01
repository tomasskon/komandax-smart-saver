DELETE FROM [dbo].[Transactions]
GO

ALTER TABLE [dbo].[Transactions]
	ADD [CategoryId] [uniqueidentifier] NOT NULL,
		[BalanceType] [varchar](16) NOT NULL
GO

ALTER TABLE [dbo].[Transactions] 
	WITH CHECK ADD CONSTRAINT [FK_Transactions_Categories] FOREIGN KEY([CategoryId])
	REFERENCES [dbo].[Categories] ([Id])
GO