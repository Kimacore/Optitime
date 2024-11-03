using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Optitime.Migrations.History
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Companies_CompanyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssignedToUserId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberships_Teams_TeamId",
                table: "TeamMemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberships_Users_UserId",
                table: "TeamMemberships");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Departments_DepartmentId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_Projects_ProjectId",
                table: "TimeEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_Tasks_TaskId",
                table: "TimeEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_Teams_TeamId",
                table: "TimeEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_Users_UserId",
                table: "TimeEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeEntries",
                table: "TimeEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMemberships",
                table: "TeamMemberships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "TimeEntries",
                newName: "timeentries");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "teams");

            migrationBuilder.RenameTable(
                name: "TeamMemberships",
                newName: "teammemberships");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "tasks");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "projects");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "companies");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TeamId",
                table: "users",
                newName: "IX_users_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "users",
                newName: "IX_users_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "users",
                newName: "IX_users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DepartmentId",
                table: "users",
                newName: "IX_users_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CompanyId",
                table: "users",
                newName: "IX_users_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntries_UserId",
                table: "timeentries",
                newName: "IX_timeentries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntries_TeamId",
                table: "timeentries",
                newName: "IX_timeentries_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntries_TaskId",
                table: "timeentries",
                newName: "IX_timeentries_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntries_ProjectId",
                table: "timeentries",
                newName: "IX_timeentries_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_TeamName",
                table: "teams",
                newName: "IX_teams_TeamName");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_DepartmentId",
                table: "teams",
                newName: "IX_teams_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMemberships_UserId",
                table: "teammemberships",
                newName: "IX_teammemberships_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMemberships_TeamId",
                table: "teammemberships",
                newName: "IX_teammemberships_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_TaskName",
                table: "tasks",
                newName: "IX_tasks_TaskName");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ProjectId",
                table: "tasks",
                newName: "IX_tasks_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_AssignedToUserId",
                table: "tasks",
                newName: "IX_tasks_AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_RoleName",
                table: "roles",
                newName: "IX_roles_RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ProjectName",
                table: "projects",
                newName: "IX_projects_ProjectName");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_OwnerId",
                table: "projects",
                newName: "IX_projects_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentName",
                table: "departments",
                newName: "IX_departments_DepartmentName");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_CompanyId",
                table: "departments",
                newName: "IX_departments_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_departments_companies_CompanyId",
                table: "departments",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_OwnerId",
                table: "projects",
                column: "OwnerId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_projects_ProjectId",
                table: "tasks",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_users_AssignedToUserId",
                table: "tasks",
                column: "AssignedToUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_teams_TeamId",
                table: "teammemberships",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teammemberships_users_UserId",
                table: "teammemberships",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
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
                name: "FK_timeentries_users_UserId",
                table: "timeentries",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId");

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
                name: "PK_users",
                table: "users");

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
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companies",
                table: "companies");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "timeentries",
                newName: "TimeEntries");

            migrationBuilder.RenameTable(
                name: "teams",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "teammemberships",
                newName: "TeamMemberships");

            migrationBuilder.RenameTable(
                name: "tasks",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "projects",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "companies",
                newName: "Companies");

            migrationBuilder.RenameIndex(
                name: "IX_users_TeamId",
                table: "Users",
                newName: "IX_Users_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_users_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_users_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_users_DepartmentId",
                table: "Users",
                newName: "IX_Users_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_users_CompanyId",
                table: "Users",
                newName: "IX_Users_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_UserId",
                table: "TimeEntries",
                newName: "IX_TimeEntries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_TeamId",
                table: "TimeEntries",
                newName: "IX_TimeEntries_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_TaskId",
                table: "TimeEntries",
                newName: "IX_TimeEntries_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_timeentries_ProjectId",
                table: "TimeEntries",
                newName: "IX_TimeEntries_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_teams_TeamName",
                table: "Teams",
                newName: "IX_Teams_TeamName");

            migrationBuilder.RenameIndex(
                name: "IX_teams_DepartmentId",
                table: "Teams",
                newName: "IX_Teams_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_teammemberships_UserId",
                table: "TeamMemberships",
                newName: "IX_TeamMemberships_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_teammemberships_TeamId",
                table: "TeamMemberships",
                newName: "IX_TeamMemberships_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_TaskName",
                table: "Tasks",
                newName: "IX_Tasks_TaskName");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_ProjectId",
                table: "Tasks",
                newName: "IX_Tasks_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_AssignedToUserId",
                table: "Tasks",
                newName: "IX_Tasks_AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_roles_RoleName",
                table: "Roles",
                newName: "IX_Roles_RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_projects_ProjectName",
                table: "Projects",
                newName: "IX_Projects_ProjectName");

            migrationBuilder.RenameIndex(
                name: "IX_projects_OwnerId",
                table: "Projects",
                newName: "IX_Projects_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_DepartmentName",
                table: "Departments",
                newName: "IX_Departments_DepartmentName");

            migrationBuilder.RenameIndex(
                name: "IX_departments_CompanyId",
                table: "Departments",
                newName: "IX_Departments_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeEntries",
                table: "TimeEntries",
                column: "TimeEntryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMemberships",
                table: "TeamMemberships",
                column: "TeamMembershipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Companies_CompanyId",
                table: "Departments",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssignedToUserId",
                table: "Tasks",
                column: "AssignedToUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberships_Teams_TeamId",
                table: "TeamMemberships",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberships_Users_UserId",
                table: "TeamMemberships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Departments_DepartmentId",
                table: "Teams",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_Projects_ProjectId",
                table: "TimeEntries",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_Tasks_TaskId",
                table: "TimeEntries",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_Teams_TeamId",
                table: "TimeEntries",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_Users_UserId",
                table: "TimeEntries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");
        }
    }
}
