namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'97a45639-acd1-4bae-802c-b5657657f283', N'admin@vidly.com', 0, N'AKpBYKjGE/ZY6/zorQ7OV63YJcPKl2StvKYgyXh0lFAceRpaxGXyebvJevZcqpmMRQ==', N'826237ea-3323-42e6-995c-1cb97d2440b7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bad89db9-1a73-48bb-9430-d789b7363294', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'97a45639-acd1-4bae-802c-b5657657f283', N'bad89db9-1a73-48bb-9430-d789b7363294')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
