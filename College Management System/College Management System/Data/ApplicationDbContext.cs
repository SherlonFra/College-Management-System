using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using College_Management_System.Models;

namespace College_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> Students  { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
