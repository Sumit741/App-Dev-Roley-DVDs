using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationDevGroupCW.Migrations
{
    public partial class GroupCW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActorFirstname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorNumber);
                });

            migrationBuilder.CreateTable(
                name: "DVDCategory",
                columns: table => new
                {
                    CategoryNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeRestricted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDCategory", x => x.CategoryNumber);
                });

            migrationBuilder.CreateTable(
                name: "LoanType",
                columns: table => new
                {
                    LoanTypeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanDuration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanType", x => x.LoanTypeNumber);
                });

            migrationBuilder.CreateTable(
                name: "MembershipCategory",
                columns: table => new
                {
                    MembershipCategoryNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipCategoryTotalLoans = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipCategory", x => x.MembershipCategoryNumber);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    ProducerNumner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.ProducerNumner);
                });

            migrationBuilder.CreateTable(
                name: "Studio",
                columns: table => new
                {
                    StudioNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudioName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studio", x => x.StudioNumber);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserNumber);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipCategoryNumber = table.Column<int>(type: "int", nullable: true),
                    MemberLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberDOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberNumber);
                    table.ForeignKey(
                        name: "FK_Member_MembershipCategory_MembershipCategoryNumber",
                        column: x => x.MembershipCategoryNumber,
                        principalTable: "MembershipCategory",
                        principalColumn: "MembershipCategoryNumber");
                });

            migrationBuilder.CreateTable(
                name: "DVDTitle",
                columns: table => new
                {
                    DVDNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DVDTitleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerNumber = table.Column<int>(type: "int", nullable: true),
                    CategroyNumber = table.Column<int>(type: "int", nullable: true),
                    StudioNumber = table.Column<int>(type: "int", nullable: true),
                    DateReleased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StandardCharge = table.Column<float>(type: "real", nullable: false),
                    PenaltyCharge = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDTitle", x => x.DVDNumber);
                    table.ForeignKey(
                        name: "FK_DVDTitle_DVDCategory_CategroyNumber",
                        column: x => x.CategroyNumber,
                        principalTable: "DVDCategory",
                        principalColumn: "CategoryNumber");
                    table.ForeignKey(
                        name: "FK_DVDTitle_Producer_ProducerNumber",
                        column: x => x.ProducerNumber,
                        principalTable: "Producer",
                        principalColumn: "ProducerNumner");
                    table.ForeignKey(
                        name: "FK_DVDTitle_Studio_StudioNumber",
                        column: x => x.StudioNumber,
                        principalTable: "Studio",
                        principalColumn: "StudioNumber");
                });

            migrationBuilder.CreateTable(
                name: "CastMembers",
                columns: table => new
                {
                    DVDNumber = table.Column<int>(type: "int", nullable: true),
                    ActorNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CastMembers_Actor_ActorNumber",
                        column: x => x.ActorNumber,
                        principalTable: "Actor",
                        principalColumn: "ActorNumber");
                    table.ForeignKey(
                        name: "FK_CastMembers_DVDTitle_DVDNumber",
                        column: x => x.DVDNumber,
                        principalTable: "DVDTitle",
                        principalColumn: "DVDNumber");
                });

            migrationBuilder.CreateTable(
                name: "DVDCopy",
                columns: table => new
                {
                    CopyNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DVDNumber = table.Column<int>(type: "int", nullable: true),
                    DatePurchased = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDCopy", x => x.CopyNumber);
                    table.ForeignKey(
                        name: "FK_DVDCopy_DVDTitle_DVDNumber",
                        column: x => x.DVDNumber,
                        principalTable: "DVDTitle",
                        principalColumn: "DVDNumber");
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    LoanNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanTypeNumber = table.Column<int>(type: "int", nullable: true),
                    CopyNumber = table.Column<int>(type: "int", nullable: true),
                    MemberNumber = table.Column<int>(type: "int", nullable: true),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReturned = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.LoanNumber);
                    table.ForeignKey(
                        name: "FK_Loan_DVDCopy_CopyNumber",
                        column: x => x.CopyNumber,
                        principalTable: "DVDCopy",
                        principalColumn: "CopyNumber");
                    table.ForeignKey(
                        name: "FK_Loan_LoanType_LoanTypeNumber",
                        column: x => x.LoanTypeNumber,
                        principalTable: "LoanType",
                        principalColumn: "LoanTypeNumber");
                    table.ForeignKey(
                        name: "FK_Loan_Member_MemberNumber",
                        column: x => x.MemberNumber,
                        principalTable: "Member",
                        principalColumn: "MemberNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_ActorNumber",
                table: "CastMembers",
                column: "ActorNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_DVDNumber",
                table: "CastMembers",
                column: "DVDNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDCopy_DVDNumber",
                table: "DVDCopy",
                column: "DVDNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitle_CategroyNumber",
                table: "DVDTitle",
                column: "CategroyNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitle_ProducerNumber",
                table: "DVDTitle",
                column: "ProducerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitle_StudioNumber",
                table: "DVDTitle",
                column: "StudioNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_CopyNumber",
                table: "Loan",
                column: "CopyNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_LoanTypeNumber",
                table: "Loan",
                column: "LoanTypeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_MemberNumber",
                table: "Loan",
                column: "MemberNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MembershipCategoryNumber",
                table: "Member",
                column: "MembershipCategoryNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastMembers");

            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "DVDCopy");

            migrationBuilder.DropTable(
                name: "LoanType");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "DVDTitle");

            migrationBuilder.DropTable(
                name: "MembershipCategory");

            migrationBuilder.DropTable(
                name: "DVDCategory");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropTable(
                name: "Studio");
        }
    }
}
