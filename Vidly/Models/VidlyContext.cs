using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Vidly.Models
{
    // Since No context type was found in the assembly 'Vidly', we add this Context class
    public class VidlyContext : DbContext
    {
        public VidlyContext()
        {

        }

        // Entities that I want to create databases from as properties of the class
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}