using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.DataBase.Tables
{
    internal class TaskRow
    {
        public int ID => _primaryKey.Key;
        public String Name { get; set; }
        private readonly PrimaryKey _primaryKey = new PrimaryKey();
    }
}
