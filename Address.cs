using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class Address
    {
        private string street;
        private string city;
        private string zipCode;

        public Address(string street, string city, string zipCode)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
        }

        public void SetStreet(string street)
        {
            this.street = street;
        }

        public string GetStreet()
        {
            return street;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetZipCode(string zipCode)
        {
            this.zipCode = zipCode;
        }

        public string GetZipCode()
        {
            return zipCode;
        }
    }
}
