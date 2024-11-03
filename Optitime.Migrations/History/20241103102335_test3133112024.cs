using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Optitime.Migrations.History
{
    /// <inheritdoc />
    public partial class test3133112024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_companies_CompanyId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_users_OwnerId1",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_projects_ProjectId",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_users_AssignedToUserId1",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_teammemberships_teams_TeamId",
                table: "teammemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_teammemberships_users_UserId1",
                table: "teammemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_teams_departments_DepartmentId",
                table: "teams");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_projects_ProjectId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_tasks_TaskId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_teams_TeamId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_users_UserId1",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_users_companies_CompanyId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_departments_DepartmentId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_RoleId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_teams_TeamId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_timeentries",
                table: "timeentries");

            migrationBuilder.DropIndex(
                name: "IX_timeentries_UserId1",
                table: "timeentries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teammemberships",
                table: "teammemberships");

            migrationBuilder.DropIndex(
                name: "IX_teammemberships_UserId1",
                table: "teammemberships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tasks",
                table: "tasks");

            migrationBuilder.DropIndex(
                name: "IX_tasks_AssignedToUserId1",
                table: "tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_OwnerId1",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companies",
                table: "companies");

            migrationBuilder.DropColumn(
                name: "TimeEntryId",
                table: "timeentries");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "TeamMembershipId",
                table: "teammemberships");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "companies");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "timeentries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeamName",
                table: "teams",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_teams_TeamName",
                table: "teams",
                newName: "IX_teams_Name");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "teammemberships",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AssignedToUserId1",
                table: "tasks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "roles",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_roles_RoleName",
                table: "roles",
                newName: "IX_roles_Name");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "projects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "OwnerId1",
                table: "projects",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_projects_ProjectName",
                table: "projects",
                newName: "IX_projects_Name");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "departments",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_departments_DepartmentName",
                table: "departments",
                newName: "IX_departments_Name");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "companies",
                newName: "Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "TeamId",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "timeentries",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TeamId",
                table: "timeentries",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TaskId",
                table: "timeentries",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectId",
                table: "timeentries",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "teams",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "teams",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "teammemberships",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "TeamId",
                table: "teammemberships",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectId",
                table: "tasks",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AssignedToUserId",
                table: "tasks",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "roles",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "projects",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "departments",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "departments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "companies",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_timeentries",
                table: "timeentries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teammemberships",
                table: "teammemberships",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tasks",
                table: "tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projects",
                table: "projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companies",
                table: "companies",
                column: "Id");

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
                name: "FK_departments_companies_CompanyId",
                table: "departments",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_OwnerId",
                table: "projects",
                column: "OwnerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_projects_ProjectId",
                table: "tasks",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_users_AssignedToUserId",
                table: "tasks",
                column: "AssignedToUserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_teams_TeamId",
                table: "teammemberships",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_users_UserId",
                table: "teammemberships",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teams_departments_DepartmentId",
                table: "teams",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_projects_ProjectId",
                table: "timeentries",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_tasks_TaskId",
                table: "timeentries",
                column: "TaskId",
                principalTable: "tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_teams_TeamId",
                table: "timeentries",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_users_UserId",
                table: "timeentries",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_companies_CompanyId",
                table: "users",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_departments_DepartmentId",
                table: "users",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_RoleId",
                table: "users",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_teams_TeamId",
                table: "users",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_companies_CompanyId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_users_OwnerId",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_projects_ProjectId",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_users_AssignedToUserId",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_teammemberships_teams_TeamId",
                table: "teammemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_teammemberships_users_UserId",
                table: "teammemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_teams_departments_DepartmentId",
                table: "teams");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_projects_ProjectId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_tasks_TaskId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_teams_TeamId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_timeentries_users_UserId",
                table: "timeentries");

            migrationBuilder.DropForeignKey(
                name: "FK_users_companies_CompanyId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_departments_DepartmentId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_RoleId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_teams_TeamId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_timeentries",
                table: "timeentries");

            migrationBuilder.DropIndex(
                name: "IX_timeentries_UserId",
                table: "timeentries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teammemberships",
                table: "teammemberships");

            migrationBuilder.DropIndex(
                name: "IX_teammemberships_UserId",
                table: "teammemberships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tasks",
                table: "tasks");

            migrationBuilder.DropIndex(
                name: "IX_tasks_AssignedToUserId",
                table: "tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_OwnerId",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companies",
                table: "companies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "companies");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "timeentries",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "teams",
                newName: "TeamName");

            migrationBuilder.RenameIndex(
                name: "IX_teams_Name",
                table: "teams",
                newName: "IX_teams_TeamName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "teammemberships",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tasks",
                newName: "AssignedToUserId1");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "roles",
                newName: "RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_roles_Name",
                table: "roles",
                newName: "IX_roles_RoleName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "projects",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "projects",
                newName: "OwnerId1");

            migrationBuilder.RenameIndex(
                name: "IX_projects_Name",
                table: "projects",
                newName: "IX_projects_ProjectName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "departments",
                newName: "DepartmentName");

            migrationBuilder.RenameIndex(
                name: "IX_departments_Name",
                table: "departments",
                newName: "IX_departments_DepartmentName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "companies",
                newName: "CompanyName");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "timeentries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "timeentries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "timeentries",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "timeentries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeEntryId",
                table: "timeentries",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "teams",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "teams",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "teammemberships",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "teammemberships",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "TeamMembershipId",
                table: "teammemberships",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "tasks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignedToUserId",
                table: "tasks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "tasks",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "roles",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "projects",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "projects",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "departments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "departments",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "companies",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_timeentries",
                table: "timeentries",
                column: "TimeEntryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teammemberships",
                table: "teammemberships",
                column: "TeamMembershipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tasks",
                table: "tasks",
                column: "TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projects",
                table: "projects",
                column: "ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companies",
                table: "companies",
                column: "CompanyId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_departments_companies_CompanyId",
                table: "departments",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_OwnerId1",
                table: "projects",
                column: "OwnerId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_projects_ProjectId",
                table: "tasks",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_users_AssignedToUserId1",
                table: "tasks",
                column: "AssignedToUserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_teams_TeamId",
                table: "teammemberships",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_users_UserId1",
                table: "teammemberships",
                column: "UserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teams_departments_DepartmentId",
                table: "teams",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_projects_ProjectId",
                table: "timeentries",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_tasks_TaskId",
                table: "timeentries",
                column: "TaskId",
                principalTable: "tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_teams_TeamId",
                table: "timeentries",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_timeentries_users_UserId1",
                table: "timeentries",
                column: "UserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_companies_CompanyId",
                table: "users",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_departments_DepartmentId",
                table: "users",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_RoleId",
                table: "users",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_teams_TeamId",
                table: "users",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "TeamId");
        }
    }
}
