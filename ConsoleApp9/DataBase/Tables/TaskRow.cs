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
    internal class TaskRow
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; }
    }
}
