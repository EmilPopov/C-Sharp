
namespace Teleimot.Web.Api.Models.RealEstates
{
    using System;
    using AutoMapper;
    using Mapping;
    using Data.Models;

    public class PublicRealEstatesResponseModel : IMapFrom<RealEstate>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int SellingPrice { get; set; }

        public int RentingPrice { get; set; }

        public bool  CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

    }
}