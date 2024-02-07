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
    internal class PriceRow
    {
        [Key]
        public int ID { get; set; }
        public int TaskId { get; set; }
        public int Price { get; set; }
        public short Year { get; set; }
    }
}
