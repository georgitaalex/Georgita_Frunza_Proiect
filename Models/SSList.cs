using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Georgita_Frunza_Proiect.Models
{
    public class SSList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(50), Unique]
        public string Sport { get; set; }
        public string Instructor { get; set; }
        public string Locatie { get; set; }
    }
}