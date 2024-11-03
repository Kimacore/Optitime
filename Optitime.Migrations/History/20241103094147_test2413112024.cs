using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Optitime.Migrations.History
{
    /// <inheritdoc />
    public partial class test2413112024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_users_OwnerId",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_users_AssignedToUserId",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_teammemberships_users_UserId",
                table: "teammemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_users_UserId",
                table: "timeentries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_timeentries_UserId",
                table: "timeentries");

            migrationBuilder.DropIndex(
                name: "IX_teammemberships_UserId",
                table: "teammemberships");

            migrationBuilder.DropIndex(
                name: "IX_tasks_AssignedToUserId",
                table: "tasks");

            migrationBuilder.DropIndex(
                name: "IX_projects_OwnerId",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "users",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "users",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "timeentries",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "teammemberships",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedToUserId1",
                table: "tasks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId1",
                table: "projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserPassword",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPassword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPassword_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_timeentries_UserId1",
                table: "timeentries",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_teammemberships_UserId1",
                table: "teammemberships",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_AssignedToUserId1",
                table: "tasks",
                column: "AssignedToUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_projects_OwnerId1",
                table: "projects",
                column: "OwnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPassword_UserId",
                table: "UserPassword",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_OwnerId1",
                table: "projects",
                column: "OwnerId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_users_AssignedToUserId1",
                table: "tasks",
                column: "AssignedToUserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_users_UserId1",
                table: "teammemberships",
                column: "UserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_users_UserId1",
                table: "timeentries",
                column: "UserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_users_OwnerId1",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_users_AssignedToUserId1",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_teammemberships_users_UserId1",
                table: "teammemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_users_UserId1",
                table: "timeentries");

            migrationBuilder.DropTable(
                name: "UserPassword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_timeentries_UserId1",
                table: "timeentries");

            migrationBuilder.DropIndex(
                name: "IX_teammemberships_UserId1",
                table: "teammemberships");

            migrationBuilder.DropIndex(
                name: "IX_tasks_AssignedToUserId1",
                table: "tasks");

            migrationBuilder.DropIndex(
                name: "IX_projects_OwnerId1",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "timeentries");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "teammemberships");

            migrationBuilder.DropColumn(
                name: "AssignedToUserId1",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "projects");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "users",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "users",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_timeentries_UserId",
                table: "timeentries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_teammemberships_UserId",
                table: "teammemberships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_AssignedToUserId",
                table: "tasks",
                column: "AssignedToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_OwnerId",
                table: "projects",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_OwnerId",
                table: "projects",
                column: "OwnerId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_users_AssignedToUserId",
                table: "tasks",
                column: "AssignedToUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_users_UserId",
                table: "teammemberships",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_users_UserId",
                table: "timeentries",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId");
        }
    }
}
