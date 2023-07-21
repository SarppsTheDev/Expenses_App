using expenses_core;
using Microsoft.AspNetCore.Mvc;

namespace expenses_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ExpensesController : ControllerBase
{
    private readonly IExpensesServices _expensesServices;
    
    public ExpensesController(IExpensesServices expensesServices)
    {
        _expensesServices = expensesServices;
    }

    [HttpGet]
    public IActionResult GetExpenses()
    {
        return Ok(_expensesServices.GetExpenses());
    }

    [HttpGet("{id}", Name = "GetExpense")]
    public IActionResult GetExpense(int id)
    {
        return Ok(_expensesServices.GetExpense(id));
    }
}