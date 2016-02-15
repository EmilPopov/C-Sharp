namespace Teleimot.Data
{

    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class TeleimotDbContext : IdentityDbContext<User>,ITeleimotDbContext
    {
        public TeleimotDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<RealEstate> RealEstates { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public static TeleimotDbContext Create()
        {
            return new TeleimotDbContext();
        }

    }
}
