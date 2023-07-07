using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigBangTest.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Admin_id = table.Column<int>(type: "int", nullable: false),
                    Admin_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Motel",
                columns: table => new
                {
                    motel_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomOptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motel", x => x.motel_Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    room_Id = table.Column<int>(type: "int", nullable: false),
                    room_Number = table.Column<int>(type: "int", nullable: true),
                    Room_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available_Status = table.Column<bool>(type: "bit", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    motel_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.room_Id);
                    table.ForeignKey(
                        name: "FK_Room_Motel_motel_Id",
                        column: x => x.motel_Id,
                        principalTable: "Motel",
                        principalColumn: "motel_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_motel_Id",
                table: "Room",
                column: "motel_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Motel");
        }
    }
}
