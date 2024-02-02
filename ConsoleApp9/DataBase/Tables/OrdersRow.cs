using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.DataBase.Tables
{
    internal class OrdersRow
    {
        public int ID => _primaryKey.Key;
        public DateTime OpenTime { get; set; }
        public int TaskId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CloseTime { get; set; }
        public DateTime AcceptedTime { get; set; }
        private readonly PrimaryKey _primaryKey = new PrimaryKey();

    }
}
