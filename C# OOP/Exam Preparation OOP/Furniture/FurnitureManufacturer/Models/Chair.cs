
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    public class Chair : Furniture , IChair , IFurniture
    {
         public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs { get; private set; }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
        }
       
    }
}
