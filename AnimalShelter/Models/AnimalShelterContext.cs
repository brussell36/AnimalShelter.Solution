using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Flash", Story = "Little bit of a scaredy cat, but will be a lover once he knows you.", Age = 4, Gender = "Male", ImageUrl = "https://www.washingtonian.com/wp-content/uploads/2019/02/milada-vigerova-1295750-unsplash-2048x3072.jpg"},
          new Cat { CatId = 2, Name = "Jazz", Story = "Biggest cuddler and sweetest boy.", Age = 6, Gender = "Male", ImageUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_weight_other/1800x1200_cat_weight_other.jpg?resize=600px:*"},
          new Cat { CatId = 3, Name = "Raisin", Story = "Will follow you wherever you go.", Age = 1, Gender = "Female", ImageUrl = "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_960_720.jpg"},
          new Cat { CatId = 4, Name = "Maya", Story = "Knows what she wants and how to manipulate you to get it.", Age = 2, Gender = "Female", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQshoMsYa1hFvjaMAwebiP2l99ssM_XWVrp7g&usqp=CAU"},
          new Cat { CatId = 5, Name = "Shiva", Story = "She has always been that small and always will be.", Age = 7, Gender = "Female", ImageUrl = "https://www.treehouseanimals.org/wp-content/uploads/2020/02/cat-care-banner-mobile-scaled.jpg"}
        );

      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Baloo", Story = "Born with no hip sockets, had them installed by doctors later. Will love you forever.", Age = 2, Gender = "Male", ImageUrl = "https://images.pexels.com/photos/662417/pexels-photo-662417.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
          new Dog { DogId = 2, Name = "Hambone", Story = "Always wants to run in the park.", Age = 3, Gender = "Female", ImageUrl = "https://images.pexels.com/photos/59523/pexels-photo-59523.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
          new Dog { DogId = 3, Name = "Ziggy", Story = "Give him treats and take him for walks and he is yours.", Age = 5, Gender = "Male", ImageUrl = "https://images.pexels.com/photos/58997/pexels-photo-58997.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
          new Dog { DogId = 4, Name = "Duchess", Story = "Wants to sits in your lap and burrow under the covers to keep your feet warm.", Age = 2, Gender = "Female", ImageUrl = "https://images.pexels.com/photos/981062/pexels-photo-981062.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
          new Dog { DogId = 5, Name = "Bowser", Story = "Super active and playful, wants a family that spends most of their time outside.", Age = 1, Gender = "Male", ImageUrl = "https://images.pexels.com/photos/733416/pexels-photo-733416.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"}
        );
    }
  }
}