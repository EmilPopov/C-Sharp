﻿namespace Teleimot.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RealEstate
    {
        private ICollection<Comment> comments;

        public RealEstate()
        {
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public RealEstateType RealEstateType { get; set; }

        public int ConstructionYear { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public string Address { get; set; }

        public int SellingPrice { get; set; }

        public int RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

        [Required]
        public string Contact { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
