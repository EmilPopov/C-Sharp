
namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int GeneralWoodValue = 2;
        public Wood(string name,Location location = null)
            :base(name,GeneralWoodValue,ItemType.Wood,location)
        {
        }
        public override void UpdateWithInteraction(string interaction)
        {
            if (GeneralWoodValue > 0 && interaction == "drop")
            {
                this.Value -= 1;
            }
        }
    }
}
