
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    public class ConvertibleChair : Chair , IFurniture , IChair , IConvertibleChair
    {
        private const decimal ChangeHeight = 0.10M ;
        private bool isConverted;
          public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height,numberOfLegs)
         {
             this.isConverted = false;
         }
          public bool IsConverted 
          {
              get { return this.isConverted;} 
          }
       
        public void Convert()
        {
            this.isConverted = !this.isConverted;
            if (IsConverted)
            {
                this.Height += ChangeHeight;
            }
            else
            {
                this.Height -= ChangeHeight;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {6}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
