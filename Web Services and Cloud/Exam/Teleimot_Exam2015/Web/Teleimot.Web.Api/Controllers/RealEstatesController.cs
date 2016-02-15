namespace Teleimot.Web.Api.Controllers
{
    using System.Web.Http;
    using Services.Data;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Models.RealEstates;
    using System.Linq;

    public class RealEstatesController : ApiController
    {
        private IRealEstatesService realEstates;

        public RealEstatesController(IRealEstatesService realEstates)
        {
            this.realEstates = realEstates;
        }

        public IHttpActionResult Get(int page = 0)
        {
            var result = this.realEstates
                .GetPublicRealEstate(page)
                .ProjectTo<PublicRealEstatesResponseModel>()
                .ToList();

            return this.Ok(result);

        }

     [Authorize]
     [HttpPost]
     public IHttpActionResult Post(CreateRealEstateRequestModel model)
     {
         if (model == null || !this.ModelState.IsValid)
         {

             if (model == null)
             {
                 return this.BadRequest("Game cannot be empty");
             }

             return this.BadRequest(this.ModelState);
         }

         var newRealEstate = this.realEstates.CreateRealEstate(
                        model.Title,
                        model.Description,
                        model.Address,
                        model.Contact,
                        model.ConstructionYear,
                        model.SellingPrice,
                        model.RentingPrice,
                        model.Type);

         var result = Mapper.Map<PublicRealEstatesResponseModel>(newRealEstate);

         return this.Created(string.Format("/api/RealEstates/{0} ", newRealEstate.Id), result);
     }
    }
}
