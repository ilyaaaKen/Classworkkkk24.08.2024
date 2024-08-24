using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ShopEntityFramework
{
    class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Worker
    {

    }
    class Shop
    {

    }
    class City
    {

    }
    class Country
    {

    }
    class Product
    {

    }
    class Category
    {

    }
    class ShopDbContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}