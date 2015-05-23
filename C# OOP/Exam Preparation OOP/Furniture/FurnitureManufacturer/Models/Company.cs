
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Common;
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Company : ICompany
    {
        private const int MinNameLength = 5;
        private const int RegistrationNumberLength = 10;


        private ICollection<IFurniture> furnitures;
        private string name;
        private string registrationNumber;
        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Company name  cannot be empty or null ");
                Validator.CheckIfStringLengthIsValid(value, MinNameLength, "Company name  cannot be less than 5 symbols");
                this.name = value;
            }
        }


        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length != RegistrationNumberLength)
                {
                    throw new IndexOutOfRangeException("Registration number must be exactly 10 symbols");
                }
                foreach (var symbol in value)
                {
                    if (!char.IsDigit(symbol))
                    {
                        throw new IndexOutOfRangeException("Registration number must contain only digits");
                    }
                }
                this.registrationNumber = value;
            }
        }


        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture>(this.furnitures); }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            foreach (var furniture in furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model))
            {
                result.AppendLine(furniture.ToString());
            }
            return result.ToString().Trim();
        }
    }
}
