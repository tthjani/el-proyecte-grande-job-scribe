using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobScribe_stranger_strings.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Founded = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CvModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOffers_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOffers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_CvModels_CVModelId",
                        column: x => x.CVModelId,
                        principalTable: "CvModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_CvModels_CVModelId",
                        column: x => x.CVModelId,
                        principalTable: "CvModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MustHaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobOfferId = table.Column<int>(type: "int", nullable: false),
                    CVModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MustHaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MustHaves_CvModels_CVModelId",
                        column: x => x.CVModelId,
                        principalTable: "CvModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MustHaves_JobOffers_JobOfferId",
                        column: x => x.JobOfferId,
                        principalTable: "JobOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NiceToHaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobOfferId = table.Column<int>(type: "int", nullable: false),
                    CVModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiceToHaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NiceToHaves_CvModels_CVModelId",
                        column: x => x.CVModelId,
                        principalTable: "CvModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NiceToHaves_JobOffers_JobOfferId",
                        column: x => x.JobOfferId,
                        principalTable: "JobOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "Id", "Email", "Gender", "Location", "Name", "TelephoneNumber", "UserName" },
                values: new object[] { 1, "valaki@valaki.vl", "Male", "Deb", "Pista", "785656456456", "pistavok12" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Description", "Founded", "Industry", "Location", "Name" },
                values: new object[,]
                {
                    { 3, "In 2014, we started Codecool with the vision that quality coding education can change lives and workplaces for the better.", 2014, "Education", "Budapest", "CodeCool" },
                    { 4, "Polygence is a team of academics and educators united in our passion to make research more widely accessible to all interested students.", 2019, "Education", "Budapest", "Polygence" },
                    { 5, "Ulyssys is one of the leading software development companies in Hungary with a team of 300 professionals. It has a 30-year successful track record in custom software development.", 1991, "IT Services and IT Consulting", "Budapest", "Ulyssys Kft." },
                    { 6, "OPSWAT protects critical infrastructure (CIP). Our goal is to eliminate malware and zero-day attacks.", 2002, "Information technology & services", "Veszprém", "OPSWAT" },
                    { 7, "Born in Stuttgart, made for the world. At Flexopus, we create New Work together with our customers. As a leading workplace management B2B software, we enable the flexible and digital management of office resources in one tool.", 2020, "Web tools", "Budapest", "Flexopus" }
                });

            migrationBuilder.InsertData(
                table: "CvModels",
                columns: new[] { "Id", "BirthDate", "Category", "Description", "Education", "Email", "IsActive", "Level", "Location", "Name", "TelephoneNumber" },
                values: new object[] { 1, new DateTime(1932, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", "Én megyek oda", "diploma", "valaki@valaki.vl", true, "Senior", "Mucsaröcsöge", "Pista", "8768716273462" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CVModelId", "Item" },
                values: new object[] { 1, 1, "Voltam már balatonon" });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "ApplicantId", "Category", "CompanyId", "Description", "IsActive", "Level", "Location", "Name", "Published" },
                values: new object[] { 1, 1, "DevOps", 4, "Valami leírás kell", true, "junior", "Nyíregyh", "DevOps Engineer", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CVModelId", "Item" },
                values: new object[] { 1, 1, "English" });

            migrationBuilder.InsertData(
                table: "MustHaves",
                columns: new[] { "Id", "CVModelId", "Item", "JobOfferId" },
                values: new object[] { 1, 1, "Javascript", 1 });

            migrationBuilder.InsertData(
                table: "NiceToHaves",
                columns: new[] { "Id", "CVModelId", "Item", "JobOfferId" },
                values: new object[] { 2, 1, "React", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CVModelId",
                table: "Experiences",
                column: "CVModelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_ApplicantId",
                table: "JobOffers",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_CompanyId",
                table: "JobOffers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CVModelId",
                table: "Languages",
                column: "CVModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MustHaves_CVModelId",
                table: "MustHaves",
                column: "CVModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MustHaves_JobOfferId",
                table: "MustHaves",
                column: "JobOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_NiceToHaves_CVModelId",
                table: "NiceToHaves",
                column: "CVModelId");

            migrationBuilder.CreateIndex(
                name: "IX_NiceToHaves_JobOfferId",
                table: "NiceToHaves",
                column: "JobOfferId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "MustHaves");

            migrationBuilder.DropTable(
                name: "NiceToHaves");

            migrationBuilder.DropTable(
                name: "CvModels");

            migrationBuilder.DropTable(
                name: "JobOffers");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
