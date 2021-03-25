using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class MovieCollectionDbContext : DbContext //A session with the database, used to query and save instances of objects
                                                      //CharityDbContext is a specific instance of a DbContext. How we do CRUD
    {
        public MovieCollectionDbContext(DbContextOptions<MovieCollectionDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }

}
