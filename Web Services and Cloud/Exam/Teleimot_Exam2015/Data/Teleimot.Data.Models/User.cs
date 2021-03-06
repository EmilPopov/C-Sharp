﻿namespace Teleimot.Data.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        //private ICollection<RealEstate> realEstates;
        //private ICollection<Comment> comments;

        //public User()
        //{
        //    this.realEstates = new HashSet<RealEstate>();
        //    this.comments = new HashSet<Comment>();
        //}

        //[Range(1, 5)]
        //public decimal Rating { get; set; }

        //public virtual ICollection<RealEstate> RealEstates
        //{
        //    get { return this.realEstates; }
        //    set { this.realEstates = value; }
        //}

        //public virtual ICollection<Comment> Comments
        //{
        //    get { return this.comments; }
        //    set { this.comments = value; }
        //}

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
