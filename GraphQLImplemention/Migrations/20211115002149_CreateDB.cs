using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLImplemention.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Roll = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Roll" },
                values: new object[,]
                {
                    { 1, "ahmed", "1001" },
                    { 2, "mohamed", "1002" },
                    { 3, "amer", "1003" },
                    { 4, "hazeem", "1004" },
                    { 5, "hamza", "1005" },
                    { 6, "hassan", "1006" },
                    { 7, "ebrahim", "1007" },
                    { 8, "moataz", "1008" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
