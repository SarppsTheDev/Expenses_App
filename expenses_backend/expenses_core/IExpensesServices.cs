using expenses_db;

namespace expenses_core;

public interface IExpensesServices
{
    Expense GetExpense(int id);
    List<Expense> GetExpenses();
    Expense CreateExpense(Expense expense);
    void DeleteExpense(Expense expense);
    Expense EditExpense(Expense expense);
}