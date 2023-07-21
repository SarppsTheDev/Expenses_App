using expenses_db;

namespace expenses_core;

public interface IExpensesServices
{
    Expense GetExpense(int id);
    List<Expense> GetExpenses();
}