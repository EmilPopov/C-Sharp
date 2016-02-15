namespace Teleimot.Web.Api.Models.RealEstates
{
    using Data.Models;
    using Mapping;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateRealEstateRequestModel : IMapFrom<RealEstate>
    {
        [Required]
        public string Address { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public int SellingPrice { get; set; }

        public int RentingPrice { get; set; }

        public int Type { get; set; }

        [Required]
        public string Contact { get; set; }

        public int ConstructionYear { get; set; }


    }
}