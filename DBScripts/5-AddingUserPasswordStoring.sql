CREATE TABLE dbo.UserLogins
(
	UserId uniqueidentifier NOT NULL,
	LoginData varbinary(2000) NOT NULL,
	CreatedDate datetime2(7) NOT NULL
)  ON [PRIMARY]
ALTER TABLE dbo.UserLogins ADD CONSTRAINT PK_UserLogins PRIMARY KEY CLUSTERED 
(
	UserId
) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

ALTER TABLE dbo.UserLogins ADD CONSTRAINT DF_UserLogins_CreatedDate DEFAULT (getutcdate()) FOR CreatedDate

ALTER TABLE dbo.UserLogins WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users] FOREIGN KEY([UserId])
REFERENCES dbo.Users ([Id])
GO