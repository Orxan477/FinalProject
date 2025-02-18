﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Models;
using Restaurant.Data.Configurations;

namespace Restaurant.Data.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) {}

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutOption> AboutOptions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ChooseRestaurant> ChooseRestaurants { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<HomeIntro> HomeIntros { get; set; }
        public DbSet<MenuImage> MenuImages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RestaurantPhotos> RestaurantPhotos { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<TokenBlackList> TokenBlackList { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FullOrder> FullOrders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new AboutOptionConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ChooseRestaurantConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new HomeIntroConfiguration());
            modelBuilder.ApplyConfiguration(new MenuImageConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantPhotosConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialConfiguration());
            modelBuilder.ApplyConfiguration(new SubscribeConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new ContactUsConfiguration());
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new FullOrderConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
