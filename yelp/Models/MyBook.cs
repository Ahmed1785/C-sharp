using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;



namespace yelp.Models
{
    
    public class Mybook
    {
        [Key]
        public int MybookId { get; set; }

        public User Reader { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

    }
}