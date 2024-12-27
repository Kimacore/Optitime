using Optitime.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
namespace Optitime.Api
{
    public static class ProjectsApi
    {
        public static RouteGroupBuilder MapProjectsApi(this RouteGroupBuilder api)
        {
            api.MapGet("/{ownerId}", async (Guid ownerId, AppDbContext db) =>
            {
                
                var userExists = await db.User.AnyAsync(u => u.Id == ownerId);
                if (!userExists)
                {
                    return Results.NotFound($"Пользователь с ID '{ownerId}' не найден.");
                }

                
                var projects = await db.Project
                    .Where(p => p.OwnerId == ownerId)
                    .ToListAsync();

                return Results.Ok(projects);
            });

            api.MapPost("/create", async ([FromBody] CreateProjectDto projectDto, AppDbContext db) =>
            {
                if (string.IsNullOrWhiteSpace(projectDto.Name) ||
                    string.IsNullOrWhiteSpace(projectDto.Status) ||
                    projectDto.StartDate == default ||
                    projectDto.OwnerId == Guid.Empty)
                {
                    return Results.BadRequest("Заполните все обязательные поля.");
                }

                var owner = await db.User.FindAsync(projectDto.OwnerId);
                if (owner is null)
                {
                    return Results.NotFound($"Пользователь с ID '{projectDto.OwnerId}' не найден.");
                }

                var newProject = new Project
                {
                    Id = Guid.NewGuid(),
                    Name = projectDto.Name,
                    Description = projectDto.Description,
                    StartDate = projectDto.StartDate.ToUniversalTime(),
                    EndDate = projectDto.EndDate.ToUniversalTime(),
                    Status = projectDto.Status,
                    OwnerId = projectDto.OwnerId
                };

                db.Project.Add(newProject);
                await db.SaveChangesAsync();

                return Results.Created($"/projects/{newProject.Id}", newProject);
            });

            api.MapDelete("/delete/{id:guid}", async (Guid id, AppDbContext db) =>
            {
                var project = await db.Project.FindAsync(id);
                if (project is null)
                {
                    return Results.NotFound($"Проект с ID '{id}' не найден.");
                }

                db.Project.Remove(project);
                await db.SaveChangesAsync();

                return Results.Ok($"Проект с ID '{id}' успешно удалён.");
            });

            return api;
        }
    }
}
