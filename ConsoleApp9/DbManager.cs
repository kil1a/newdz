using ConsoleApp9.DataBase;
using ConsoleApp9.DataBase.Tables;

namespace ConsoleApp9
{
    public class DbManager :IDisposable
    {
        private const string HorizontalLine = "======================================================================";
        private OrderBD _database = new OrderBD();

        public void PopulateTasks()
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Please populate [Tasks] table:");
            InsertTask();
            Console.WriteLine("Populating [Tasks] table finished");
            Console.WriteLine(HorizontalLine);

        }
        public void InsertTask()
        {
            Console.WriteLine("Please populate [Tasks] row:");
            Console.WriteLine("Please write data in [Name] way:");
            var taskRow = new TaskRow();
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {

            }
            else
            {
                taskRow.Name = name;
                _database.Tasks.Add(taskRow);
                InsertTask();
            }

        }

        public void Dispose()
        {
        }

    }
}
