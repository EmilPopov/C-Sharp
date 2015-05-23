
namespace AcademyEcosystem
{
    public class Boar : Animal, IHerbivore, ICarnivore
    {
        private const int StartBoarSize = 4;
        private const int BiteSize = 2;

        public Boar(string name, Point location)
            : base(name, location, StartBoarSize)
        {
            
        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal == null)
            {
                return 0;
            }
            if (animal.Size <= this.Size)
            {
               return animal.GetMeatFromKillQuantity();
            }
            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(BiteSize);
            }
            return 0;
        }
    }
}
