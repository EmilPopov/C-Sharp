namespace Teleimot.Services.Data
{
    using System;
    using System.Linq;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;

    public class RealEstatesService : IRealEstatesService
    {
        private IRepository<RealEstate> realEstates;

        public RealEstatesService(IRepository<RealEstate> realEstates)
        {
            this.realEstates = realEstates;
        }


        public IQueryable<RealEstate> GetPublicRealEstate(int page = 0)
        {
            return this.realEstates
                .All()
                .OrderByDescending(r => r.CreatedOn)
                .Skip(page * 10)
                .Take(10);
        }

        public RealEstate CreateRealEstate(string title, string description, string address, string contact, int constructionYear, int sellingPrice, int rentingPrice, int type)
        {
            var newRealEstate = new RealEstate
            {
                Title = title,
                Description = description,
                Address = address,
                Contact = contact,
                ConstructionYear = constructionYear,
                SellingPrice = sellingPrice,
                RentingPrice = rentingPrice,
                RealEstateType = (RealEstateType)type
            };

            this.realEstates.Add(newRealEstate);
            this.realEstates.SaveChanges();

            return newRealEstate;
        }
    }
}

