using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSHospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedAgentLoginDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginAppointment_AgentLogin_AgentLoginsId",
                table: "AgentLoginAppointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginDepartment_AgentLogin_AgentLoginsId",
                table: "AgentLoginDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginDoctor_AgentLogin_AgentLoginsId",
                table: "AgentLoginDoctor");

            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginHospital_AgentLogin_AgentLoginsId",
                table: "AgentLoginHospital");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_AgentLogin_AgentLoginId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgentLogin",
                table: "AgentLogin");

            migrationBuilder.RenameTable(
                name: "AgentLogin",
                newName: "AgentLogins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgentLogins",
                table: "AgentLogins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginAppointment_AgentLogins_AgentLoginsId",
                table: "AgentLoginAppointment",
                column: "AgentLoginsId",
                principalTable: "AgentLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginDepartment_AgentLogins_AgentLoginsId",
                table: "AgentLoginDepartment",
                column: "AgentLoginsId",
                principalTable: "AgentLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginDoctor_AgentLogins_AgentLoginsId",
                table: "AgentLoginDoctor",
                column: "AgentLoginsId",
                principalTable: "AgentLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginHospital_AgentLogins_AgentLoginsId",
                table: "AgentLoginHospital",
                column: "AgentLoginsId",
                principalTable: "AgentLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AgentLogins_AgentLoginId",
                table: "Patients",
                column: "AgentLoginId",
                principalTable: "AgentLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginAppointment_AgentLogins_AgentLoginsId",
                table: "AgentLoginAppointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginDepartment_AgentLogins_AgentLoginsId",
                table: "AgentLoginDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginDoctor_AgentLogins_AgentLoginsId",
                table: "AgentLoginDoctor");

            migrationBuilder.DropForeignKey(
                name: "FK_AgentLoginHospital_AgentLogins_AgentLoginsId",
                table: "AgentLoginHospital");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_AgentLogins_AgentLoginId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgentLogins",
                table: "AgentLogins");

            migrationBuilder.RenameTable(
                name: "AgentLogins",
                newName: "AgentLogin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgentLogin",
                table: "AgentLogin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginAppointment_AgentLogin_AgentLoginsId",
                table: "AgentLoginAppointment",
                column: "AgentLoginsId",
                principalTable: "AgentLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginDepartment_AgentLogin_AgentLoginsId",
                table: "AgentLoginDepartment",
                column: "AgentLoginsId",
                principalTable: "AgentLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginDoctor_AgentLogin_AgentLoginsId",
                table: "AgentLoginDoctor",
                column: "AgentLoginsId",
                principalTable: "AgentLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgentLoginHospital_AgentLogin_AgentLoginsId",
                table: "AgentLoginHospital",
                column: "AgentLoginsId",
                principalTable: "AgentLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AgentLogin_AgentLoginId",
                table: "Patients",
                column: "AgentLoginId",
                principalTable: "AgentLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
