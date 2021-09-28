using System;

namespace _2._1
{
    class Address
    {
        private string _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;

        public string index
        {
            get
            {
                return _index;
            }
            set
            {
                this._index = value;
            }
        }
        public string country
        {
            get
            {
                return _country;
            }
            set
            {
                this._country = value;
            }
        }
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                this._city = value;
            }
        }
        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                this._street = value;
            }
        }
        public string house
        {
            get
            {
                return _house;
            }
            set
            {
                this._house = value;
            }
        }
        public string apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                this._apartment = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Index: {_index} Country: {_country} City: {_city} Street: {_street} House: {_house} Apartment: {_apartment}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address adressOne = new Address();
            adressOne.index = "07400";
            adressOne.country = "Ukraine";
            adressOne.city = "Brovary";
            adressOne.street = "Kievskaya 288";
            adressOne.house = "3";
            adressOne.apartment = "87";
            adressOne.GetInfo();


        }
    }
}
