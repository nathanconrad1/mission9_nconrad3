﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission9_nconrad3.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
