using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace auction.Models
{
    public class Bid
    {
        [Key]
        public int bid_id { get; set; }
        public int nextbid { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        // public List<User> postedcomments { get; set; }
        // public List<Message> messagecommented { get; set; }
        [ForeignKey("user_id")]
        public int user_id { get; set; }
        [ForeignKey("product_id")]
        public int product_id { get; set; }

    }
}