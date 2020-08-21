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
          new Cat { CatId = 1, Name = "Flash", Story = "Little bit of a scaredy cat, but will be a lover once he knows you.", Age = 4, Gender = "Male"},
          new Cat { CatId = 2, Name = "Jazz", Story = "Biggest cuddler and sweetest boy.", Age = 6, Gender = "Male"},
          new Cat { CatId = 3, Name = "Raisin", Story = "Will follow you wherever you go.", Age = 1, Gender = "Female"},
          new Cat { CatId = 4, Name = "Maya", Story = "Knows what she wants and how to manipulate you to get it.", Age = 2, Gender = "Female"},
          new Cat { CatId = 5, Name = "Shiva", Story = "She has always been that small and always will be.", Age = 7, Gender = "Female"}
        );

      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Baloo", Story = "Born with no hip sockets, had them installed by doctors later. Will love you forever.", Age = 2, Gender = "Male"},
          new Dog { DogId = 2, Name = "Hambone", Story = "Always wants to run in the park.", Age = 3, Gender = "Female"},
          new Dog { DogId = 3, Name = "Ziggy", Story = "Give him treats and take him for walks and he is yours.", Age = 5, Gender = "Male"},
          new Dog { DogId = 4, Name = "Duchess", Story = "Wants to sits in your lap and burrow under the covers to keep your feet warm.", Age = 2, Gender = "Female"},
          new Dog { DogId = 5, Name = "Bowser", Story = "Super active and playful, wants a family that spends most of their time outside.", Age = 1, Gender = "Male"}
        );
    }
  }
}