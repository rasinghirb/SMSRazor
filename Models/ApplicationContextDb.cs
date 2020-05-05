using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSRazor.Models
{
    public class ApplicationContextDb:DbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb>options):base(options)
        {

        }
        public DbSet<Books> Book { get; set; }
    }
}
