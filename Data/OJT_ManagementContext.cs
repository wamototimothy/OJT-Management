﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OJT_Management.Models;

namespace OJT_Management.Data
{
    public class OJT_ManagementContext : DbContext
    {
        public OJT_ManagementContext (DbContextOptions<OJT_ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<OJT_Management.Models.Staff> Staff { get; set; } = default!;
    }
}
