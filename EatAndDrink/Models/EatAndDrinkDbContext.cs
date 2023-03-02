using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EatAndDrink.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        

    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


    }

    public class Courier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


    }

    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Ingregients {get; set;}


    }

    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Catalog { get; set; }

    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeCooking { get; set; }
        public double Price { get; set; }


    }

    public class Restorant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OpenedYear { get; set; }

    }

    public class EatAndDrinkDbContext : DbContext
    {
        private readonly String _connectionString = "Data Source=сервер;InitialCatalog=EatAndDrinkDB;Persist Security Info=True;User ID = sa; Password=123";
        public DbSet<Person> Persons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restorant> Restorants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(_connectionString);
    }
}