using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class ApplicationContext: DbContext

    {
        public ApplicationContext(DbContextOptions<ApplicationContext> context) :base(context)
        {

        }
        public DbSet<Make> Makes { get; set; }
    }
}
