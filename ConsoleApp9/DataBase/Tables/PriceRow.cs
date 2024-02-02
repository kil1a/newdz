using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.DataBase.Tables
{
    internal class PriceRow
    {
        public int ID => _primaryKey.Key;
        public int TaskId { get; set; }
        public int Price { get; set; }
        public short Year { get; set; }
        private readonly PrimaryKey _primaryKey = new PrimaryKey();
    }
}
