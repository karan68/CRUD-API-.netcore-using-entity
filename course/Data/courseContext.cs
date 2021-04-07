using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using course.Models;

namespace course.Data
{
    public class courseContext : DbContext
    {
        public courseContext (DbContextOptions<courseContext> options)
            : base(options)
        {
        }

        public DbSet<course.Models.Course> Course { get; set; }
    }
}
