using expenses_db;
using expenses_core.DTO;
using Microsoft.AspNetCore.Http;

namespace expenses_core;

public class ExpensesServices : IExpensesServices
{
    private AppDbContext _context;
    private readonly User _user;

    public ExpensesServices(AppDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _user = _context.Users.First(u => u.Username == httpContextAccessor.HttpContext.User.Identity.Name);
    }

    public ExpenseDTO GetExpense(int id) =>
        _context.Expenses
            .Where(e => e.User.Id == _user.Id && e.Id == id)
            .Select(e => (ExpenseDTO)e)
            .First();

    public List<ExpenseDTO> GetExpenses() =>
        _context.Expenses
            .Where(e => e.User.Id == _user.Id)
            .Select(e => (ExpenseDTO)e)
            .ToList();

    public ExpenseDTO CreateExpense(Expense expense)
    {
        expense.User = _user;
        _context.Add(expense);
        _context.SaveChanges();

        return (ExpenseDTO)expense;
    }

    public void DeleteExpense(ExpenseDTO expense)
    {
        var dbExpense = _context.Expenses.First(e => e.User.Id == _user.Id && e.Id == expense.Id);
        _context.Expenses.Remove(dbExpense);
        _context.SaveChanges();
    }

    public ExpenseDTO EditExpense(ExpenseDTO expense)
    {
        var dbExpense = _context.Expenses.First(e => e.User.Id == _user.Id && e.Id == expense.Id);
        dbExpense.Description = expense.Description;
        dbExpense.Amount = expense.Amount;
        _context.SaveChanges();

        return expense;
    }
}