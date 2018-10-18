using Microsoft.EntityFrameworkCore;
 
namespace yelp.Models
{
    public class MainContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
        public DbSet<User> user { get; set;}

        public DbSet<Book> book { get; set;}

        public  DbSet<Mybook> mybook {get; set;}
    
    }
}