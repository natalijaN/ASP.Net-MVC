using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    AverageFreeTime = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Descrition = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ImporanceOfTask = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TypeOfToDo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Descrition = table.Column<string>(nullable: true),
                    ToDoID = table.Column<int>(nullable: false),
                    SubStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTasks_ToDos_ToDoID",
                        column: x => x.ToDoID,
                        principalTable: "ToDos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AverageFreeTime", "FirstName", "LastName" },
                values: new object[] { 1, 5m, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Descrition", "ImporanceOfTask", "Status", "Title", "TypeOfToDo", "UserId" },
                values: new object[] { 1, null, 2, 2, "Basketball Training", 3, 1 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Descrition", "ImporanceOfTask", "Status", "Title", "TypeOfToDo", "UserId" },
                values: new object[] { 2, null, 1, 1, "Project", 1, 1 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Descrition", "ImporanceOfTask", "Status", "Title", "TypeOfToDo", "UserId" },
                values: new object[] { 3, null, 1, 3, "Reading Book", 2, 1 });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "Id", "Descrition", "SubStatus", "Title", "ToDoID" },
                values: new object[,]
                {
                    { 1, "Workout before Training", 1, "Workout", 1 },
                    { 2, "Spa after Training", 1, "Spa", 1 },
                    { 3, "Analyze Data", 0, "Analyze", 2 },
                    { 4, "Design Engine", 1, "Design", 2 },
                    { 5, "Go to the library", 0, "Go to the library", 3 },
                    { 6, "You need to start reading the book", 1, "ReadTheBook", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_ToDoID",
                table: "SubTasks",
                column: "ToDoID");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_UserId",
                table: "ToDos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
