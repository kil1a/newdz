using ConsoleApp9.DataBase.Tables;
using Microsoft.Data.Sqlite;
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
            //ошибка была здесь, она заключалась в том что листы с нашими таблицами небыли проинициализированны, вот как можно было это исправить:

            //Orders = new List<OrdersRow>();

            //Prices = new List<PriceRow>();

            //Tasks = new List<TaskRow>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionStringBuilder = new SqliteConnectionStringBuilder()
                {
                    DataSource = "db.sqlite"
                };
                var connectionString = connectionStringBuilder.ToString();
                var connection = new SqliteConnection(connectionString);

                optionsBuilder.UseSqlite(connection);
            }
        }


    }
}
