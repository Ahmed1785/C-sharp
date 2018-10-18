using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace yelp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        public List<Mybook> Mybook {get; set;}

        public User()
        {
            Mybook = new List<Mybook>();
        }

    }

    public class LoginUser
    {


        [Key]
        public long loguser_id { get; set; }

        [Required]
        [EmailAddress]
        public string LogEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string LogPassword { get; set; }

    }

      


    }