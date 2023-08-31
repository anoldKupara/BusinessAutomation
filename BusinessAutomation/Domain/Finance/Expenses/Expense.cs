namespace BusinessAutomation.Domain.Finance.Expenses
{
    public class Expense
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set;}
        public DateTime Date { get; set; }
    }
}
