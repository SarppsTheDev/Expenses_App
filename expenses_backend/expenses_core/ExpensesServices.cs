using expenses_db;

namespace expenses_core;

public class ExpensesServices : IExpensesServices
{
    public AppDbContext _context;
    
    public ExpensesServices(AppDbContext context)
    {
        _context = context;
    }

    public Expense GetExpense(int id)
    {
        return _context.Expenses.FirstOrDefault(e => e.Id == id);
    }
    
    public List<Expense> GetExpenses()
    {
        return _context.Expenses.ToList();
    }
}