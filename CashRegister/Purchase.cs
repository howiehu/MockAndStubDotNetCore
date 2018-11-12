namespace CashRegister
{
    public class Purchase
    {
        private readonly Item[] _items;

        public Purchase(Item[] items)
        {
            _items = items;
        }

        public string AsString()
        {
            string output = "";

            foreach (var item in _items)
            {
                output += item.Name + "\t" + item.Price + "\n";
            }

            return output;
        }
    }
}