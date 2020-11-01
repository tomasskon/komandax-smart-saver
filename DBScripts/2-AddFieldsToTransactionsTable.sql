ALTER TABLE [dbo].[Transactions]
	ADD [CreatedAt] [smalldatetime]
	CONSTRAINT [DF_Transactions_CreatedAt] DEFAULT GETDATE()
WITH VALUES
GO
