using expenses_db;

namespace expenses.core;

public class ExpensesServices : IExpensesServices
{
    public AppDbContext _context;
    
    public ExpensesServices(AppDbContext context)
    {
        _context = context;
    }
    
    public List<Expense> GetExpenses()
    {
        return _context.Expenses.ToList();
    }
}