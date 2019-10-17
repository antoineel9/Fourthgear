using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FourthGear.Data;

namespace FourthGear.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FourthGear.Data.Admin> Admin { get; set; }
        public DbSet<FourthGear.Data.DeptHead> DeptHead { get; set; }
        public DbSet<FourthGear.Data.SLT> SLT { get; set; }
    }
}
