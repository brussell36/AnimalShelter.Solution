﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200821203459_Images")]
    partial class Images
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("Story");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 4,
                            Gender = "Male",
                            ImageUrl = "https://www.washingtonian.com/wp-content/uploads/2019/02/milada-vigerova-1295750-unsplash-2048x3072.jpg",
                            Name = "Flash",
                            Story = "Little bit of a scaredy cat, but will be a lover once he knows you."
                        },
                        new
                        {
                            CatId = 2,
                            Age = 6,
                            Gender = "Male",
                            ImageUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_weight_other/1800x1200_cat_weight_other.jpg?resize=600px:*",
                            Name = "Jazz",
                            Story = "Biggest cuddler and sweetest boy."
                        },
                        new
                        {
                            CatId = 3,
                            Age = 1,
                            Gender = "Female",
                            ImageUrl = "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_960_720.jpg",
                            Name = "Raisin",
                            Story = "Will follow you wherever you go."
                        },
                        new
                        {
                            CatId = 4,
                            Age = 2,
                            Gender = "Female",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQshoMsYa1hFvjaMAwebiP2l99ssM_XWVrp7g&usqp=CAU",
                            Name = "Maya",
                            Story = "Knows what she wants and how to manipulate you to get it."
                        },
                        new
                        {
                            CatId = 5,
                            Age = 7,
                            Gender = "Female",
                            ImageUrl = "https://www.treehouseanimals.org/wp-content/uploads/2020/02/cat-care-banner-mobile-scaled.jpg",
                            Name = "Shiva",
                            Story = "She has always been that small and always will be."
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("Story");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 2,
                            Gender = "Male",
                            ImageUrl = "https://images.pexels.com/photos/662417/pexels-photo-662417.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Baloo",
                            Story = "Born with no hip sockets, had them installed by doctors later. Will love you forever."
                        },
                        new
                        {
                            DogId = 2,
                            Age = 3,
                            Gender = "Female",
                            ImageUrl = "https://images.pexels.com/photos/59523/pexels-photo-59523.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Hambone",
                            Story = "Always wants to run in the park."
                        },
                        new
                        {
                            DogId = 3,
                            Age = 5,
                            Gender = "Male",
                            ImageUrl = "https://images.pexels.com/photos/58997/pexels-photo-58997.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Ziggy",
                            Story = "Give him treats and take him for walks and he is yours."
                        },
                        new
                        {
                            DogId = 4,
                            Age = 2,
                            Gender = "Female",
                            ImageUrl = "https://images.pexels.com/photos/981062/pexels-photo-981062.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Duchess",
                            Story = "Wants to sits in your lap and burrow under the covers to keep your feet warm."
                        },
                        new
                        {
                            DogId = 5,
                            Age = 1,
                            Gender = "Male",
                            ImageUrl = "https://images.pexels.com/photos/733416/pexels-photo-733416.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            Name = "Bowser",
                            Story = "Super active and playful, wants a family that spends most of their time outside."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
