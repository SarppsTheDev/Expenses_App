using expenses_db;

namespace expenses.core;

public interface IExpensesServices
{
    List<Expense> GetExpenses();
}