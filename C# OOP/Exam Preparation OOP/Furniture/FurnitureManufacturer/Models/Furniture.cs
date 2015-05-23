
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Common;
    using FurnitureManufacturer.Interfaces;
    using System;
    public abstract class Furniture : IFurniture
    {
        private const int MinModelLength = 3;

        private string model;
        private decimal price;
        private decimal height;
        //TODO : materialType;
        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
        }
        public string Model
        {
            get { return this.model; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Model cannot be empty or null");
                Validator.CheckIfStringLengthIsValid(value, MinModelLength, "Model cannot be less than 3 symbols");
                this.model = value;
            }
        }

        public string Material { get; private set; }
      

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.CheckIfLessOrEqualToZero(value, "Price cannot be less or equal to $0.00.");
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set
            {
                Validator.CheckIfLessOrEqualToZero(value, "Height cannot be less or equal to 0.00 m");
            }
        }
    }
}
