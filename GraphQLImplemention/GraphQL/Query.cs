using GraphQLImplemention.Data;
using GraphQLImplemention.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLImplemention.GraphQL
{
    public class Query
    {
        private readonly ApplicationContext _context;

        public Query(ApplicationContext context)
        {
            _context = context;
        }

        public IQueryable<Student> Students => _context.Students;
    }
}
