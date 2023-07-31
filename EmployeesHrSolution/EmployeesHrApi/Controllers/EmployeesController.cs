using EmployeesHrApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeesHrApi.Controllers;

public class EmployeesController :ControllerBase
{
    private readonly EmployeeDataContext _context;

    public EmployeesController(EmployeeDataContext context)
    {
        _context = context;
    }

    [HttpGet("/employees")]
    public async Task<ActionResult> GetEmployeesAsync()
    {
        var employees = await _context.Employees.ToListAsync();
        return Ok(employees);
    }

}
