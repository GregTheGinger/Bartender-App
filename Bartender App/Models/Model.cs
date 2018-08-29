////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Threading.Tasks;

////namespace Bartender App.Models
////{
////    public class Model
////{
////}
////}


//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using EFGetStarted.AspNetCore.NewDb.Models;


//namespace EFGetStarted.AspNetCore.NewDb.Models
//{
//    public class Drink : DbContext
//    {
//        public Drink(DbContextOptions<Drink> options)
//            : base(options)
//        { }

//        public DbSet<Drink> Drinks { get; set; }
//        public DbSet<Quantity> Quantity { get; set; }
//    }

//    public class DrinkName
//    {
//        public int DrinkID { get; set; }
//        public string NameOfDrink { get; set; }
//    }

//    public class Quantity
//    {
//        public int Ammount { get; set; }

//        public int DrinkID { get; set; }
//        public DrinkName DrinkName { get; set; }
//    }
//}
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}