using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManagementRepository.Migrations
{
    public partial class initialdbc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "passengerAncillaryServices",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengerAncillaryServices", x => x.SeatId);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.SeatId);
                });

            migrationBuilder.CreateTable(
                name: "credentials",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_credentials", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_credentials_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    FlightCompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FlightCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LandingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TakeOffTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_flights_seats_FlightId",
                        column: x => x.FlightId,
                        principalTable: "seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "flightServices",
                columns: table => new
                {
                    FlightServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightServices", x => x.FlightServiceId);
                    table.ForeignKey(
                        name: "FK_flightServices_flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "passengers",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Passport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    IsWheelChair = table.Column<bool>(type: "bit", nullable: false),
                    IsInfant = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengers", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_passengers_flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_passengers_passengerAncillaryServices_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "passengerAncillaryServices",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ancillaryServices",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ancillaryServices", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_ancillaryServices_flightServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "flightServices",
                        principalColumn: "FlightServiceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ancillaryServices_passengerAncillaryServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "passengerAncillaryServices",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ancillaryServices_seats_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_credentials_RoleId",
                table: "credentials",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_flightServices_FlightId",
                table: "flightServices",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_passengers_FlightId",
                table: "passengers",
                column: "FlightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ancillaryServices");

            migrationBuilder.DropTable(
                name: "credentials");

            migrationBuilder.DropTable(
                name: "passengers");

            migrationBuilder.DropTable(
                name: "flightServices");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "passengerAncillaryServices");

            migrationBuilder.DropTable(
                name: "flights");

            migrationBuilder.DropTable(
                name: "seats");
        }
    }
}
