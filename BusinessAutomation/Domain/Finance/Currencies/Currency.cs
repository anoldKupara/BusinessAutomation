namespace BusinessAutomation.Domain.Finance.Currencies
{
    public class Currency
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string CurrencyCode { get; set; }
    }
}
