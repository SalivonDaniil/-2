using System;

namespace _2._8
{
    class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;
        private string _article;
        private int _quantity;

        public string article
        {
            get
            {
                return _article;
            }
            set
            {
                this._article = value;
            }
        }
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public double AccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Customer} заказал у {Provider} {_quantity} {_article} и получил счет, который будет составлять {Account} без Ндс, и {AccountWithNds()} с Ндс");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1060, "Иван Иванович", "Епицентра")
            {
                quantity = 15,
                article = "молотков"
            };
            invoice.AccountWithNds();
            invoice.GetInfo();
        }
    }
}
