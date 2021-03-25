using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class IMovieCollectionRepository //Creating a template which is meant to be inherited. Like a base class
    {
        IQueryable<Movie> Movies { get; }
    }

}
