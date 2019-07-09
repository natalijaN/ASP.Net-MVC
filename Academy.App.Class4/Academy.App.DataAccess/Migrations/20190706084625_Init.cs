using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Academy.App.DataAccess.Migrations
{
    public partial class Init : Migrations
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Academy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    EstimatedTime = table.Column<int>(nullable: false),
                    TimeSpent = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Academy", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 1, 26, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Academy", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 2, 23, "Jane", "Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Academy", "Age", "FirstName", "LastName" },
                values: new object[] { 3, 3, 29, "Mark", "Brown" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EstimatedTime", "StudentId", "TimeSpent", "Title" },
                values: new object[,]
                {
                    { 1, 20, 1, 25, "ToDo App" },
                    { 5, 70, 1, 68, "Market App" },
                    { 2, 30, 2, 45, "Pizza App" },
                    { 4, 80, 2, 100, "Bank App" },
                    { 3, 20, 3, 15, "Calculator App" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StudentId",
                table: "Projects",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
