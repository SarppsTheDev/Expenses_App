using expenses_db;

namespace expenses_core.DTO;

public class ExpenseDTO
{
    public int Id { get; set; }
    public string Description { get; set; }
    public double Amount { get; set; }

    public static explicit operator ExpenseDTO(Expense e) => new ExpenseDTO
    {
        Id = e.Id,
        Amount = e.Amount,
        Description = e.Description
    };
}