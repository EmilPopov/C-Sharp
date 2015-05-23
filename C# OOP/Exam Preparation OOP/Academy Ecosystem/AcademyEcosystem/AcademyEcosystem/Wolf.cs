

namespace AcademyEcosystem
{
    public class Wolf : Animal,ICarnivore
    {
        private const int WolfSize = 4;
         public Wolf(string name, Point location)
            : base(name, location,WolfSize)
        {
        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal == null)
            {
                return 0;
            }
            if ((animal.Size <= this.Size) || animal.State == AnimalState.Sleeping) // or sleep
            {
                return animal.GetMeatFromKillQuantity();                
            }
            return 0;
        }
        public override void Update(int timeElapsed)
        {
            base.Update(timeElapsed);  // TO DO
        }
    }
}
