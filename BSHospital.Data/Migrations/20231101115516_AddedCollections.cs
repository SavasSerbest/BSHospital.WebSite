using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSHospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCollections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "HaveSurgery",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IsAllergic",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IsSick",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgentLoginId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AgentLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                    UptadedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgentLoginAppointment",
                columns: table => new
                {
                    AgentLoginsId = table.Column<int>(type: "int", nullable: false),
                    AppointmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLoginAppointment", x => new { x.AgentLoginsId, x.AppointmentsId });
                    table.ForeignKey(
                        name: "FK_AgentLoginAppointment_AgentLogin_AgentLoginsId",
                        column: x => x.AgentLoginsId,
                        principalTable: "AgentLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentLoginAppointment_Appointments_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentLoginDepartment",
                columns: table => new
                {
                    AgentLoginsId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLoginDepartment", x => new { x.AgentLoginsId, x.DepartmentsId });
                    table.ForeignKey(
                        name: "FK_AgentLoginDepartment_AgentLogin_AgentLoginsId",
                        column: x => x.AgentLoginsId,
                        principalTable: "AgentLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentLoginDepartment_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentLoginDoctor",
                columns: table => new
                {
                    AgentLoginsId = table.Column<int>(type: "int", nullable: false),
                    DoctorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLoginDoctor", x => new { x.AgentLoginsId, x.DoctorsId });
                    table.ForeignKey(
                        name: "FK_AgentLoginDoctor_AgentLogin_AgentLoginsId",
                        column: x => x.AgentLoginsId,
                        principalTable: "AgentLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentLoginDoctor_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentLoginHospital",
                columns: table => new
                {
                    AgentLoginsId = table.Column<int>(type: "int", nullable: false),
                    HospitalsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLoginHospital", x => new { x.AgentLoginsId, x.HospitalsId });
                    table.ForeignKey(
                        name: "FK_AgentLoginHospital_AgentLogin_AgentLoginsId",
                        column: x => x.AgentLoginsId,
                        principalTable: "AgentLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentLoginHospital_Hospitals_HospitalsId",
                        column: x => x.HospitalsId,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AgentLoginId",
                table: "Patients",
                column: "AgentLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentLoginAppointment_AppointmentsId",
                table: "AgentLoginAppointment",
                column: "AppointmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentLoginDepartment_DepartmentsId",
                table: "AgentLoginDepartment",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentLoginDoctor_DoctorsId",
                table: "AgentLoginDoctor",
                column: "DoctorsId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentLoginHospital_HospitalsId",
                table: "AgentLoginHospital",
                column: "HospitalsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AgentLogin_AgentLoginId",
                table: "Patients",
                column: "AgentLoginId",
                principalTable: "AgentLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_AgentLogin_AgentLoginId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "AgentLoginAppointment");

            migrationBuilder.DropTable(
                name: "AgentLoginDepartment");

            migrationBuilder.DropTable(
                name: "AgentLoginDoctor");

            migrationBuilder.DropTable(
                name: "AgentLoginHospital");

            migrationBuilder.DropTable(
                name: "AgentLogin");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AgentLoginId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AgentLoginId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HaveSurgery",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllergic",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSick",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
