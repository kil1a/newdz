using ConsoleApp9.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.DataBase
{
    internal class OrderBD
    {
        public List<OrdersRow> Orders { get; set; }
        public List<PriceRow> Prices { get; set; }
        public List<TaskRow> Tasks { get; set; }
    }
}
