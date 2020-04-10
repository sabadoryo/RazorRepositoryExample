using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesStudent.Models;

namespace RazorPagesStudent.Data
{
    public class RazorPagesStudentContext : DbContext
    {
        public RazorPagesStudentContext (DbContextOptions<RazorPagesStudentContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesStudent.Models.Student> Student { get; set; }
    }
}
