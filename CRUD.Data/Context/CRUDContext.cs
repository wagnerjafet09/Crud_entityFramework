using CRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Person> Person { get; set; }
    }
}
