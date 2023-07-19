using expenses_db;

namespace expenses_core;

public interface IExpensesServices
{
    List<Expense> GetExpenses();
}