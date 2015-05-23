

namespace AcademyEcosystem
{
    public class Lion : Animal,ICarnivore
    {
       private const int StartLionSize = 6;
         public Lion(string name, Point location)
            : base(name, location,StartLionSize)
        {
        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal == null)
            {
                return 0;
            }
            if (animal.Size <= this.Size * 2)
            {
                this.Size++;
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
