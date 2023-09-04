using expenses_core.DTO;
using expenses_db;

namespace expenses_core;

public interface IExpensesServices
{
    ExpenseDTO GetExpense(int id);
    List<ExpenseDTO> GetExpenses();
    ExpenseDTO CreateExpense(Expense expense);
    void DeleteExpense(ExpenseDTO expense);
    ExpenseDTO EditExpense(ExpenseDTO expense);
}