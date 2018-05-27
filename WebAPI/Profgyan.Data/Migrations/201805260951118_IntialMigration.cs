namespace Profgyan.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        AppointmentId = c.String(nullable: false, maxLength: 128),
                        TraineeId = c.String(maxLength: 128),
                        TrainerId = c.String(maxLength: 128),
                        Phone = c.String(maxLength: 50),
                        Message = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.AppointmentId);
            
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        AttendanceId = c.String(nullable: false, maxLength: 128),
                        SessionId = c.String(maxLength: 128),
                        TraineeId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AttendanceId);
            
            CreateTable(
                "dbo.BookMarks",
                c => new
                    {
                        BookmarkId = c.String(nullable: false, maxLength: 128),
                        CourseId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BookmarkId);
            
            CreateTable(
                "dbo.Chat",
                c => new
                    {
                        ChatID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 50),
                        Comments = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ChatID);
            
            CreateTable(
                "dbo.CommonDetails",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        ComDetailId = c.String(maxLength: 128),
                        Address = c.String(maxLength: 200),
                        AcademicYear = c.DateTime(),
                        DOB = c.DateTime(),
                        Department = c.String(maxLength: 50),
                        Grade = c.String(maxLength: 50),
                        Photo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Trainee", t => t.ComDetailId)
                .ForeignKey("dbo.Trainers", t => t.ComDetailId)
                .Index(t => t.ComDetailId);
            
            CreateTable(
                "dbo.Trainee",
                c => new
                    {
                        TraineeID = c.String(nullable: false, maxLength: 128),
                        UserID = c.String(maxLength: 128),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        ComDetailId = c.String(maxLength: 50),
                        AreaOfIntrest = c.String(),
                        StatusId = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.TraineeID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerId = c.String(nullable: false, maxLength: 128),
                        UserID = c.String(maxLength: 128),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        ComDetailId = c.String(maxLength: 128),
                        TypeId = c.Int(),
                        TrDetailId = c.String(maxLength: 128),
                        RatingId = c.String(maxLength: 128),
                        StatusId = c.String(maxLength: 128),
                        IsVerified = c.Boolean(),
                    })
                .PrimaryKey(t => t.TrainerId);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.String(nullable: false, maxLength: 128),
                        CourseName = c.String(maxLength: 50),
                        Description = c.String(),
                        Logo = c.Binary(storeType: "image"),
                        StatusId = c.String(maxLength: 128),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        DocumentId = c.String(nullable: false, maxLength: 128),
                        Filepath = c.String(maxLength: 200),
                        Foldername = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DocumentId);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentId = c.String(nullable: false, maxLength: 128),
                        CourseId = c.String(maxLength: 128),
                        TrainerId = c.String(maxLength: 128),
                        DateEnrolled = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        ModifiedDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.EnrollmentId);
            
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        FeedbackId = c.String(nullable: false, maxLength: 128),
                        Comments = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FeedbackId);
            
            CreateTable(
                "dbo.PaymentModes",
                c => new
                    {
                        ModeId = c.String(nullable: false, maxLength: 128),
                        Mode = c.String(maxLength: 20),
                        StatusId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ModeId);
            
            CreateTable(
                "dbo.Rating",
                c => new
                    {
                        RatingId = c.String(nullable: false, maxLength: 128),
                        StarsCount = c.Int(),
                    })
                .PrimaryKey(t => t.RatingId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Session",
                c => new
                    {
                        SessionId = c.String(nullable: false, maxLength: 128),
                        Timing = c.DateTime(),
                        CourseId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SessionId);
            
            CreateTable(
                "dbo.SocialMedia",
                c => new
                    {
                        SocialMediaId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 50),
                        Link = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.String(nullable: false, maxLength: 128),
                        StatusName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Subscription",
                c => new
                    {
                        SubscriptionId = c.String(nullable: false, maxLength: 128),
                        CourseId = c.String(maxLength: 128),
                        Comments = c.String(maxLength: 300, fixedLength: true),
                    })
                .PrimaryKey(t => t.SubscriptionId);
            
            CreateTable(
                "dbo.SubscriptionTrainer_Map",
                c => new
                    {
                        SubscriptionId = c.String(nullable: false, maxLength: 128),
                        TrainerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SubscriptionId);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.TrainerDetails",
                c => new
                    {
                        TrDetailId = c.String(nullable: false, maxLength: 128),
                        TrainerId = c.String(maxLength: 128),
                        Experience = c.Int(),
                        Companies = c.String(maxLength: 200),
                        SkillSet = c.String(maxLength: 300),
                        TeachingExperience = c.String(maxLength: 300),
                        Rewards = c.String(maxLength: 300),
                        TeachingReason = c.String(maxLength: 300),
                        SocialMediaId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TrDetailId);
            
            CreateTable(
                "dbo.TrainingType",
                c => new
                    {
                        TypeId = c.String(nullable: false, maxLength: 128),
                        TypeName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.UserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserLogin",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserLogin", "UserId", "dbo.User");
            DropForeignKey("dbo.UserClaim", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.CommonDetails", "ComDetailId", "dbo.Trainers");
            DropForeignKey("dbo.CommonDetails", "ComDetailId", "dbo.Trainee");
            DropIndex("dbo.UserLogin", new[] { "UserId" });
            DropIndex("dbo.UserClaim", new[] { "UserId" });
            DropIndex("dbo.User", "UserNameIndex");
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.Role", "RoleNameIndex");
            DropIndex("dbo.CommonDetails", new[] { "ComDetailId" });
            DropTable("dbo.UserLogin");
            DropTable("dbo.UserClaim");
            DropTable("dbo.User");
            DropTable("dbo.TrainingType");
            DropTable("dbo.TrainerDetails");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.SubscriptionTrainer_Map");
            DropTable("dbo.Subscription");
            DropTable("dbo.Status");
            DropTable("dbo.SocialMedia");
            DropTable("dbo.Session");
            DropTable("dbo.UserRole");
            DropTable("dbo.Role");
            DropTable("dbo.Rating");
            DropTable("dbo.PaymentModes");
            DropTable("dbo.Feedback");
            DropTable("dbo.Enrollment");
            DropTable("dbo.Documents");
            DropTable("dbo.Course");
            DropTable("dbo.Trainers");
            DropTable("dbo.Trainee");
            DropTable("dbo.CommonDetails");
            DropTable("dbo.Chat");
            DropTable("dbo.BookMarks");
            DropTable("dbo.Attendance");
            DropTable("dbo.Appointment");
        }
    }
}
