using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Lat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Lon = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleMovement = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Lat",
                table: "Addresses",
                column: "Lat");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Location",
                table: "Addresses",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Lon",
                table: "Addresses",
                column: "Lon");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AddressId",
                table: "Vehicles",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_State",
                table: "Vehicles",
                column: "State");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Type",
                table: "Vehicles",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleMovement",
                table: "Vehicles",
                column: "VehicleMovement");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
