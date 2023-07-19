using expenses_core;
using Microsoft.AspNetCore.Mvc;

namespace expenses_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ExpensesController : ControllerBase
{
    private IExpensesServices _expensesServices;
    
    public ExpensesController(IExpensesServices expensesServices)
    {
        _expensesServices = expensesServices;
    }

    [HttpGet]
    public IActionResult GetExpenses()
    {
        return Ok(_expensesServices.GetExpenses());
    }
}