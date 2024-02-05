using ConsoleApp9.DataBase.Tables;
using Microsoft.EntityFrameworkCore;



namespace ConsoleApp9.DataBase
{
    internal class OrderBD: DbContext
    {
        public DbSet<OrdersRow> Orders { get; set; }
        public DbSet<PriceRow> Prices { get; set; }
        public DbSet<TaskRow> Tasks { get; set; }
        public OrderBD()
        {
            //Orders = new DbSet<OrdersRow>();

            //Prices = new DbSet<PriceRow>();

            //Tasks = new DbSet<TaskRow>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite();

            }
              
            base.OnConfiguring(optionsBuilder);

        }


    }
}
