using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Trainer { get; set; }
    }
}
