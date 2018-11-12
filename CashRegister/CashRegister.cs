namespace CashRegister
{
    public class CashRegister
    {
        private readonly Printer _printer;

        public CashRegister(Printer printer)
        {
            _printer = printer;
        }

        public void Process(Purchase purchase)
        {
            _printer.Print(purchase.AsString());
        }
    }
}