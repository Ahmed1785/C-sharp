using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;



namespace project.Models
{
    public class Book
    {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        // [DataType(DataType.Date)]
        public String Author { get; set; }

        [Required]
        [MinLength(3)]
        public String Genre { get; set; }

        public User User { get; set; }

        public List<Mybook> Mybook { get; set; }

        public int user_id {get; set;}
    }

}