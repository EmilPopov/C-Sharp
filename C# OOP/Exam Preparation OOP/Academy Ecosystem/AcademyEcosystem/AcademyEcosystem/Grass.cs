

namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        private const int StartGarssSize = 2;
        public Grass(Point location)
            : base(location, StartGarssSize)
        {
        }
        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += time;                
            }
            base.Update(time);
        }
    }
}
