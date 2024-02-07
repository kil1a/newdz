using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.DataBase.Tables
{
    [PrimaryKey(nameof(ID))]
    internal class OrdersRow
    {
        public int ID { get; set; }
        public DateTime OpenTime { get; set; }
        public int TaskId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CloseTime { get; set; }
        public DateTime AcceptedTime { get; set; }

    }
}
