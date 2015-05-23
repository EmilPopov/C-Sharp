
namespace TradeAndTravel
{
    using System.Linq;
    using System.Collections.Generic;
    public class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }
            return item;
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;              
                default:
                    base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor,commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2],commandWords[3]);
                    break;              
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string itemTypeString, string itemName)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    this.HandleWeaponCrafting(actor, itemName);
                    break;
                case "armor":
                    this.HandleArmorCrafting(actor, itemName);
                    break;
                default:
                    break;
            }
        }

        private void HandleWeaponCrafting(Person actor, string itemName)
        {
            var itemRequired = new List<ItemType> { ItemType.Iron, ItemType.Wood };
            if (itemRequired.All(x => actor.ListInventory().Any(a => a.ItemType == x)))
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
        }

        private void HandleArmorCrafting(Person actor, string itemName)
        {
            var itemRequired = ItemType.Iron;
            if (actor.ListInventory().Any(x => x.ItemType == itemRequired))
            {
                this.AddToPerson(actor, new Armor(itemName));
            }

        }

        private void HandleGatherInteraction(Person actor,string itemName)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;
                if (actor.ListInventory().Any(x => x.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;             
                default:
                    base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return person;
        }

    }
}
