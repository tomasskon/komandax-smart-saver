ALTER TABLE [dbo].[Users]
    ADD [Cash] [float] NOT NULL DEFAULT 0,
        [Card] [float] NOT NULL DEFAULT 0,
        [UserImage] [image] NULL
GO