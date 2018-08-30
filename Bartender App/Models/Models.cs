using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class DrinkContext : DbContext
    {
        public DrinkContext(DbContextOptions<DrinkContext> options)
            : base(options)
        { }

        public DbSet<Drink> Drink { get; set; }
        public DbSet<Drinks> Drinks { get; set; }

    }

    public class Drink
    {
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }

        public List<Drinks> DrinkList { get; set; }
    }

    public class Drinks
    {
        public int DrinksID { get; set; }
        public string Name { get; set; }

        public int DrinkID { get; set; }
        public Drink Drink { get; set; }
    }
}




//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;

//namespace EFGetStarted.AspNetCore.NewDb.Models
//{
//    public class BloggingContext : DbContext
//    {
//        public BloggingContext(DbContextOptions<BloggingContext> options)
//            : base(options)
//        { }

//        public DbSet<Blog> Blogs { get; set; }
//        public DbSet<Post> Posts { get; set; }
//    }

//    public class Blog
//    {
//        public int BlogId { get; set; }
//        public string Url { get; set; }

//        public List<Post> Posts { get; set; }
//    }

//    public class Post
//    {
//        public int PostId { get; set; }
//        public string Title { get; set; }
//        public string Content { get; set; }

//        public int BlogId { get; set; }
//        public Blog Blog { get; set; }
//    }
//}