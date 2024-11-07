using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Optitime.Migrations.History
{
    /// <inheritdoc />
    public partial class _31212321344 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_adminpassword_admin_UserId",
                table: "adminpassword");

            migrationBuilder.DropForeignKey(
                name: "FK_departments_organizations_OrganizationId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_orgroles_organizations_OrganizationId",
                table: "orgroles");

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
                name: "FK_userpasswords_users_UserId",
                table: "userpasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_userroles_orgroles_OrganizationRoleId",
                table: "userroles");

            migrationBuilder.DropForeignKey(
                name: "FK_userroles_users_UserId",
                table: "userroles");

            migrationBuilder.DropForeignKey(
                name: "FK_users_approles_ApplicationRoleId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_departments_DepartmentId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_organizations_OrganizationId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_teams_TeamId",
                table: "users");

            migrationBuilder.DropTable(
                name: "OrganizationRolePrivilege");

            migrationBuilder.DropPrimaryKey(
                name: "PK_privileges",
                table: "privileges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_adminpassword",
                table: "adminpassword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admin",
                table: "admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userroles",
                table: "userroles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userpasswords",
                table: "userpasswords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_timeentries",
                table: "timeentries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teammemberships",
                table: "teammemberships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tasks",
                table: "tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orgroles",
                table: "orgroles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_organizations",
                table: "organizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_approles",
                table: "approles");

            migrationBuilder.RenameTable(
                name: "privileges",
                newName: "Privileges");

            migrationBuilder.RenameTable(
                name: "adminpassword",
                newName: "AdminPassword");

            migrationBuilder.RenameTable(
                name: "admin",
                newName: "Admin");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "userroles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "userpasswords",
                newName: "UserPassword");

            migrationBuilder.RenameTable(
                name: "timeentries",
                newName: "TimeEntry");

            migrationBuilder.RenameTable(
                name: "teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "teammemberships",
                newName: "TeamMembership");

            migrationBuilder.RenameTable(
                name: "tasks",
                newName: "Task");

            migrationBuilder.RenameTable(
                name: "projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "orgroles",
                newName: "OrgRole");

            migrationBuilder.RenameTable(
                name: "organizations",
                newName: "Organization");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "approles",
                newName: "AppRole");

            migrationBuilder.RenameIndex(
                name: "IX_adminpassword_UserId",
                table: "AdminPassword",
                newName: "IX_AdminPassword_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_users_TeamId",
                table: "User",
                newName: "IX_User_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_users_OrganizationId",
                table: "User",
                newName: "IX_User_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_users_Email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_users_DepartmentId",
                table: "User",
                newName: "IX_User_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_users_ApplicationRoleId",
                table: "User",
                newName: "IX_User_ApplicationRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_userroles_UserId",
                table: "UserRole",
                newName: "IX_UserRole_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_userroles_OrganizationRoleId",
                table: "UserRole",
                newName: "IX_UserRole_OrganizationRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_userpasswords_UserId",
                table: "UserPassword",
                newName: "IX_UserPassword_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_UserId",
                table: "TimeEntry",
                newName: "IX_TimeEntry_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_TeamId",
                table: "TimeEntry",
                newName: "IX_TimeEntry_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_TaskId",
                table: "TimeEntry",
                newName: "IX_TimeEntry_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_ProjectId",
                table: "TimeEntry",
                newName: "IX_TimeEntry_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_teams_Name",
                table: "Team",
                newName: "IX_Team_Name");

            migrationBuilder.RenameIndex(
                name: "IX_teams_DepartmentId",
                table: "Team",
                newName: "IX_Team_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_teammemberships_UserId",
                table: "TeamMembership",
                newName: "IX_TeamMembership_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_teammemberships_TeamId",
                table: "TeamMembership",
                newName: "IX_TeamMembership_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_TaskName",
                table: "Task",
                newName: "IX_Task_TaskName");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_ProjectId",
                table: "Task",
                newName: "IX_Task_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_AssignedToUserId",
                table: "Task",
                newName: "IX_Task_AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_projects_OwnerId",
                table: "Project",
                newName: "IX_Project_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_projects_Name",
                table: "Project",
                newName: "IX_Project_Name");

            migrationBuilder.RenameIndex(
                name: "IX_orgroles_OrganizationId",
                table: "OrgRole",
                newName: "IX_OrgRole_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_OrganizationId",
                table: "Department",
                newName: "IX_Department_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_Name",
                table: "Department",
                newName: "IX_Department_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Privileges",
                table: "Privileges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminPassword",
                table: "AdminPassword",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPassword",
                table: "UserPassword",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeEntry",
                table: "TimeEntry",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMembership",
                table: "TeamMembership",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrgRole",
                table: "OrgRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organization",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrgRolesPrivileges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PrivilegeId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrganizationRoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgRolesPrivileges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrgRolesPrivileges_OrgRole_OrganizationRoleId",
                        column: x => x.OrganizationRoleId,
                        principalTable: "OrgRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgRolesPrivileges_Privileges_PrivilegeId",
                        column: x => x.PrivilegeId,
                        principalTable: "Privileges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrgRolesPrivileges_OrganizationRoleId",
                table: "OrgRolesPrivileges",
                column: "OrganizationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgRolesPrivileges_PrivilegeId",
                table: "OrgRolesPrivileges",
                column: "PrivilegeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminPassword_Admin_UserId",
                table: "AdminPassword",
                column: "UserId",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Organization_OrganizationId",
                table: "Department",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgRole_Organization_OrganizationId",
                table: "OrgRole",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_User_OwnerId",
                table: "Project",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectId",
                table: "Task",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AssignedToUserId",
                table: "Task",
                column: "AssignedToUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Department_DepartmentId",
                table: "Team",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembership_Team_TeamId",
                table: "TeamMembership",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembership_User_UserId",
                table: "TeamMembership",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntry_Project_ProjectId",
                table: "TimeEntry",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntry_Task_TaskId",
                table: "TimeEntry",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntry_Team_TeamId",
                table: "TimeEntry",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntry_User_UserId",
                table: "TimeEntry",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AppRole_ApplicationRoleId",
                table: "User",
                column: "ApplicationRoleId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Department_DepartmentId",
                table: "User",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Organization_OrganizationId",
                table: "User",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Team_TeamId",
                table: "User",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPassword_User_UserId",
                table: "UserPassword",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_OrgRole_OrganizationRoleId",
                table: "UserRole",
                column: "OrganizationRoleId",
                principalTable: "OrgRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminPassword_Admin_UserId",
                table: "AdminPassword");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Organization_OrganizationId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgRole_Organization_OrganizationId",
                table: "OrgRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_User_OwnerId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AssignedToUserId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Department_DepartmentId",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembership_Team_TeamId",
                table: "TeamMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembership_User_UserId",
                table: "TeamMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntry_Project_ProjectId",
                table: "TimeEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntry_Task_TaskId",
                table: "TimeEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntry_Team_TeamId",
                table: "TimeEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntry_User_UserId",
                table: "TimeEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_User_AppRole_ApplicationRoleId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Department_DepartmentId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Organization_OrganizationId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Team_TeamId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPassword_User_UserId",
                table: "UserPassword");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_OrgRole_OrganizationRoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "OrgRolesPrivileges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Privileges",
                table: "Privileges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminPassword",
                table: "AdminPassword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPassword",
                table: "UserPassword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeEntry",
                table: "TimeEntry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMembership",
                table: "TeamMembership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrgRole",
                table: "OrgRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.RenameTable(
                name: "Privileges",
                newName: "privileges");

            migrationBuilder.RenameTable(
                name: "AdminPassword",
                newName: "adminpassword");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "admin");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "userroles");

            migrationBuilder.RenameTable(
                name: "UserPassword",
                newName: "userpasswords");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "TimeEntry",
                newName: "timeentries");

            migrationBuilder.RenameTable(
                name: "TeamMembership",
                newName: "teammemberships");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "teams");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "tasks");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "projects");

            migrationBuilder.RenameTable(
                name: "OrgRole",
                newName: "orgroles");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "organizations");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "AppRole",
                newName: "approles");

            migrationBuilder.RenameIndex(
                name: "IX_AdminPassword_UserId",
                table: "adminpassword",
                newName: "IX_adminpassword_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UserId",
                table: "userroles",
                newName: "IX_userroles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_OrganizationRoleId",
                table: "userroles",
                newName: "IX_userroles_OrganizationRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPassword_UserId",
                table: "userpasswords",
                newName: "IX_userpasswords_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_TeamId",
                table: "users",
                newName: "IX_users_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_User_OrganizationId",
                table: "users",
                newName: "IX_users_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "users",
                newName: "IX_users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_User_DepartmentId",
                table: "users",
                newName: "IX_users_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_User_ApplicationRoleId",
                table: "users",
                newName: "IX_users_ApplicationRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntry_UserId",
                table: "timeentries",
                newName: "IX_timeentries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntry_TeamId",
                table: "timeentries",
                newName: "IX_timeentries_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntry_TaskId",
                table: "timeentries",
                newName: "IX_timeentries_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntry_ProjectId",
                table: "timeentries",
                newName: "IX_timeentries_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMembership_UserId",
                table: "teammemberships",
                newName: "IX_teammemberships_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMembership_TeamId",
                table: "teammemberships",
                newName: "IX_teammemberships_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Team_Name",
                table: "teams",
                newName: "IX_teams_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Team_DepartmentId",
                table: "teams",
                newName: "IX_teams_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_TaskName",
                table: "tasks",
                newName: "IX_tasks_TaskName");

            migrationBuilder.RenameIndex(
                name: "IX_Task_ProjectId",
                table: "tasks",
                newName: "IX_tasks_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_AssignedToUserId",
                table: "tasks",
                newName: "IX_tasks_AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_OwnerId",
                table: "projects",
                newName: "IX_projects_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_Name",
                table: "projects",
                newName: "IX_projects_Name");

            migrationBuilder.RenameIndex(
                name: "IX_OrgRole_OrganizationId",
                table: "orgroles",
                newName: "IX_orgroles_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_OrganizationId",
                table: "departments",
                newName: "IX_departments_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_Name",
                table: "departments",
                newName: "IX_departments_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_privileges",
                table: "privileges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_adminpassword",
                table: "adminpassword",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admin",
                table: "admin",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userroles",
                table: "userroles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userpasswords",
                table: "userpasswords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_timeentries",
                table: "timeentries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teammemberships",
                table: "teammemberships",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tasks",
                table: "tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projects",
                table: "projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orgroles",
                table: "orgroles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_organizations",
                table: "organizations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_approles",
                table: "approles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrganizationRolePrivilege",
                columns: table => new
                {
                    OrganizationRolesId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrivilegesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationRolePrivilege", x => new { x.OrganizationRolesId, x.PrivilegesId });
                    table.ForeignKey(
                        name: "FK_OrganizationRolePrivilege_orgroles_OrganizationRolesId",
                        column: x => x.OrganizationRolesId,
                        principalTable: "orgroles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationRolePrivilege_privileges_PrivilegesId",
                        column: x => x.PrivilegesId,
                        principalTable: "privileges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationRolePrivilege_PrivilegesId",
                table: "OrganizationRolePrivilege",
                column: "PrivilegesId");

            migrationBuilder.AddForeignKey(
                name: "FK_adminpassword_admin_UserId",
                table: "adminpassword",
                column: "UserId",
                principalTable: "admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_organizations_OrganizationId",
                table: "departments",
                column: "OrganizationId",
                principalTable: "organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orgroles_organizations_OrganizationId",
                table: "orgroles",
                column: "OrganizationId",
                principalTable: "organizations",
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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_userpasswords_users_UserId",
                table: "userpasswords",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userroles_orgroles_OrganizationRoleId",
                table: "userroles",
                column: "OrganizationRoleId",
                principalTable: "orgroles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userroles_users_UserId",
                table: "userroles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_approles_ApplicationRoleId",
                table: "users",
                column: "ApplicationRoleId",
                principalTable: "approles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_departments_DepartmentId",
                table: "users",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_organizations_OrganizationId",
                table: "users",
                column: "OrganizationId",
                principalTable: "organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_teams_TeamId",
                table: "users",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
