using expenses_core;
using expenses_db;
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

    [HttpPost]
    public IActionResult CreateExpense(Expense expense)
    {
        var newExpense = _expensesServices.CreateExpense(expense);
        return CreatedAtRoute("GetExpense", new { newExpense.Id }, newExpense);
    }

    [HttpDelete]
    public IActionResult DeleteExpense(Expense expense)
    {
        _expensesServices.DeleteExpense(expense);
        return Ok();
    }

    [HttpPut]
    public IActionResult EditExpense(Expense expense)
    {
        return Ok(_expensesServices.EditExpense(expense));
    }
}