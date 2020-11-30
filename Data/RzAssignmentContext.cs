using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RzAssignment.Models;

namespace RzAssignment.Data
{
    public class RzAssignmentContext : DbContext
    {
        public RzAssignmentContext (DbContextOptions<RzAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<RzAssignment.Models.Movies> Movies { get; set; }
    }
}
