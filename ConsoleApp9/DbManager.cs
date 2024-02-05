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
            Console.WriteLine("Пожалуйста, заполните таблицу [Tasks]:");
            InsertTask();
            Console.WriteLine("Заполнение таблицы[Tasks] завершено");
            Console.WriteLine(HorizontalLine);

        }
        public void InsertTask()
        {
            Console.WriteLine("Пожалуйста, заполните строку [Tasks]:");
            Console.WriteLine("Пожалуйста, напишите данные в формате [Name]:");
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
