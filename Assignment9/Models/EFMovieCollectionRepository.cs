using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class EFMovieCollectionRepository : IMovieCollectionRepository //The implementation of the
                                                                          //IMovieCollectionRepository Template
    {
        private MovieCollectionDbContext _context;

        public EFMovieCollectionRepository(MovieCollectionDbContext context) //The constructor
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }

}
