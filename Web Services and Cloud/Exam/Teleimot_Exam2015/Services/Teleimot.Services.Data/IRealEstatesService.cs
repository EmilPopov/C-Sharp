namespace Teleimot.Services.Data
{
    using System;
    using System.Linq;
    using Teleimot.Data.Models;

    public interface IRealEstatesService
    {
        IQueryable<RealEstate> GetPublicRealEstate(int page = 0);

        RealEstate CreateRealEstate(string title,
                                  string description,
                                  string address,
                                  string contact,
                                  int constructionYear,
                                  int sellingPrice,
                                  int rentingPrice,
                                  int type);
    }
}
