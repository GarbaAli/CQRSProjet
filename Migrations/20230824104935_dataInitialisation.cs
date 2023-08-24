using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRSProjet.Migrations
{
    public partial class dataInitialisation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Students(StudentName, StudentEmail, StudentAddress, StudentAge) VALUES ('Oumar', 'oumar@gmail.com', 'Akwa', 12)");
            migrationBuilder.Sql("INSERT INTO Students(StudentName, StudentEmail, StudentAddress, StudentAge) VALUES ('Haffan Yahya', 'yahya@gmail.com', 'Monkam', 8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Students");
        }
    }
}
