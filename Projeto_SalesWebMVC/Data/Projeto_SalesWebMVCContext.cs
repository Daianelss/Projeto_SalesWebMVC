﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_SalesWebMVC.Models;

namespace Projeto_SalesWebMVC.Data
{
    public class Projeto_SalesWebMVCContext : DbContext
    {
        public Projeto_SalesWebMVCContext (DbContextOptions<Projeto_SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
