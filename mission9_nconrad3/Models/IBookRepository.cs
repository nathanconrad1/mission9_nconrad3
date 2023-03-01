using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission9_nconrad3.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
