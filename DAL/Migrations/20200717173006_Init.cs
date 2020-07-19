using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabelTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    TranslationValue = table.Column<string>(nullable: true),
                    RefLabelIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabelTranslations_Label_RefLabelIdId",
                        column: x => x.RefLabelIdId,
                        principalTable: "Label",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Merchendise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HasStock = table.Column<bool>(nullable: false),
                    RefLabelIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchendise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merchendise_Label_RefLabelIdId",
                        column: x => x.RefLabelIdId,
                        principalTable: "Label",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    AccountType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    RefLocationIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Location_RefLocationIdId",
                        column: x => x.RefLocationIdId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateTimeStart = table.Column<DateTime>(nullable: true),
                    DateTimeEnd = table.Column<DateTime>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    RefLocationIdId = table.Column<int>(nullable: true),
                    RefLabelIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Label_RefLabelIdId",
                        column: x => x.RefLabelIdId,
                        principalTable: "Label",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Location_RefLocationIdId",
                        column: x => x.RefLocationIdId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelationUserAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<short>(nullable: true),
                    DateTimeCreatedOn = table.Column<DateTime>(nullable: true),
                    AttendanceStatus = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    RefUserIdId = table.Column<int>(nullable: true),
                    RefAppointmentIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationUserAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelationUserAppointment_Appointment_RefAppointmentIdId",
                        column: x => x.RefAppointmentIdId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelationUserAppointment_ApplicationUser_RefUserIdId",
                        column: x => x.RefUserIdId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_RefLocationIdId",
                table: "ApplicationUser",
                column: "RefLocationIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_RefLabelIdId",
                table: "Appointment",
                column: "RefLabelIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_RefLocationIdId",
                table: "Appointment",
                column: "RefLocationIdId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelTranslations_RefLabelIdId",
                table: "LabelTranslations",
                column: "RefLabelIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchendise_RefLabelIdId",
                table: "Merchendise",
                column: "RefLabelIdId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationUserAppointment_RefAppointmentIdId",
                table: "RelationUserAppointment",
                column: "RefAppointmentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationUserAppointment_RefUserIdId",
                table: "RelationUserAppointment",
                column: "RefUserIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabelTranslations");

            migrationBuilder.DropTable(
                name: "Merchendise");

            migrationBuilder.DropTable(
                name: "RelationUserAppointment");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
