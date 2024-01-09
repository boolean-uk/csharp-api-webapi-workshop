

using workshop.wwwapi.Models;
using workshop.wwwapi.Repository;

namespace workshop.wwwapi.EndPoints
{
    public static class DepartmentAPI
    {
        public static void ConfigureDepartmentAPI(this WebApplication app)
        { 
            app.MapGet("/Departments", GetDepartments);

        }

    private static async Task<IResult> GetDepartments(IDatabaseRepository<Department> repository)
    {
        try
        {
            return Results.Ok(repository.GetAll());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
}
