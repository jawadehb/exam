﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam.Models;

namespace exam
{
    internal class MyDbContext:DbContext
    {

            public DbSet<User> Users { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=quizzt;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true");
            }
        }
    }

