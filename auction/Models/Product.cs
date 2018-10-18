using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace auction.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }

        [Required]
        public int user_id { get; set; }

        [Required]
        [MinLength(3)]
        public string name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        [Range(0,1000)]
        public int startingbid { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        public User User { get; set; }

        public List<Bid> productbid {get; set;}

        public Product()
        {
            productbid = new List<Bid>();
        }

    }      
}