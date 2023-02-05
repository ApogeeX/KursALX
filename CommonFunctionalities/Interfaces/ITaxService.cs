namespace CommonFunctionalities.Interfaces
{
    public interface ITaxService
    {
        double CalculateTax(double income);

        decimal CalculateTaxDecimal(decimal income);
    }
}
