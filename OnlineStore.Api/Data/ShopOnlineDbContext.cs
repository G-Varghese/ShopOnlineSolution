using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;
namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options)
        : base(options)
        {
            Carts = Set<Cart>();
            CartItems = Set<CartItem>();
            Products = Set<Product>();
            ProductCategories = Set<ProductCategory>();
            Users = Set<User>();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Earrings Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "White Pearl Gold Drop Jhumka",
                Description = "Stylish and trendy traditional white pearl gold jhumka",
                ImageURL = "/Images/Earrings/Earrings1.png",
                Price = 50,
                Qty = 200,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Contemporary Crystal Stone",
                Description = "Muticolor stone statement earring, captivating crystal and an eye catchy lion drop",
                ImageURL = "/Images/Earrings/Earrings2.png",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Red Ruby Stones",
                Description = "Handcrafted in silver and brass alloy with cz stones",
                ImageURL = "/Images/Earrings/Earrings3.png",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Kundan Bahubali Earrings ",
                Description = "Gold and white earrings featured the iconic image of Radha and Krishna ",
                ImageURL = "/Images/Earrings/Earrings4.png",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Dome shaped Jhumkas",
                Description = "Black and gold plated enamelled dome shaped jhumkas",
                ImageURL = "/Images/Earrings/Earrings5.png",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //Bangles Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Gold Set of 12",
                Description = "Gold plated set of 12 classy design",
                ImageURL = "/Images/Bangles/Bangles1.png",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Brass Openable Kada",
                Description = "Premium quality brass base opeable bangle with multiple stones",
                ImageURL = "/Images/Bangles/Bangles2.png",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Gold Beaded Bangle",
                Description = "Alloy base material with white beads",
                ImageURL = "/Images/Bangles/Bangles3.png",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Leaf Shaped bangle Set",
                Description = "Enameled gold plated leaf shaped bangle set",
                ImageURL = "/Images/Bangles/Bangles4.png",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Jumuka Bangle Set",
                Description = "Traditional Blue and Golden color jumuka bangle set",
                ImageURL = "/Images/Bangles/Bangles5.png",
                Price = 100,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Elephant Design Kada",
                Description = "Rajwadhi plated elephant design brass kada",
                ImageURL = "/Images/Bangles/Bangles6.png",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });
            //Necklaces Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Laxmi Pendant Necklace",
                Description = "Golden necklace with laxmi pendant and green color stones",
                ImageURL = "/Images/Necklaces/Necklaces1.png",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Red Beaded Necklace",
                Description = "Three layered red color beaded neckpiece",
                ImageURL = "/Images/Necklaces/Necklaces2.png",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Golden Necklace",
                Description = "Alloy base material yellow gold plating necklace ",
                ImageURL = "/Images/Necklaces/Necklaces3.png",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Antique Tassel Necklaces",
                Description = "Alloy material with gold antique tassel necklace",
                ImageURL = "/Images/Necklaces/Necklaces4.png",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Red Ruby Necklace",
                Description = "Handcrfted in brass alloy with ruby, pearl and meenakari work",
                ImageURL = "/Images/Necklaces/Necklaces5.png",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Long Mangalsuthra",
                Description = "Golden brahmamudi long mangalsuthra with single vathi",
                ImageURL = "/Images/Necklaces/Necklaces6.png",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            //Anklets Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Baraat Patterened Angle",
                Description = "Bridal baraat muti-colored patterend angle",
                ImageURL = "/Images/Anklets/Anklets1.png",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Polki's Anklet",
                Description = "Beaurtifil Copper alloy polki's with white beads",
                ImageURL = "/Images/Anklets/Anklets2.png",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Golden Chain Anklet",
                Description = "Simple light weight elegant golden chain anklet",
                ImageURL = "/Images/Anklets/Anklets3.png",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Peacock Design Anklet",
                Description = "Beautiful simple silver paecock design anklet",
                ImageURL = "/Images/Anklets/Anklets4.png",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Gold Anklet",
                Description = "Simple round shaped gold anklet",
                ImageURL = "/Images/Anklets/Anklets5.png",
                Price = 100,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Gold Stone Anklet",
                Description = "Gold Plated anklet with muticolored stones",
                ImageURL = "/Images/Anklets/Anklets6.png",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Earring"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Necklace"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Bangles/Bracelets"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Anklet"
            });

        }
        
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
