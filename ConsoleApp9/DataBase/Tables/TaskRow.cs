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
//dotnet\dotnet.exe  ef migrations add --project ConsoleApp9\ConsoleApp9.csproj
//--startup-project ConsoleApp9\ConsoleApp9.csproj --context ConsoleApp9.DataBase.OrdersDB
//--configuration Debug Initial --output-dir Migrations