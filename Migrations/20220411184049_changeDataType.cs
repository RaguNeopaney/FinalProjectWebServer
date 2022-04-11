using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectWebServer.Migrations
{
    public partial class changeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Messsage",
                table: "ContectUs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Messsage",
                table: "ContectUs",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
