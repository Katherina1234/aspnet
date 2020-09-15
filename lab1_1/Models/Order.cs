using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1_1.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int id_timetable { get; set; }
        public int count_sits { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
}
