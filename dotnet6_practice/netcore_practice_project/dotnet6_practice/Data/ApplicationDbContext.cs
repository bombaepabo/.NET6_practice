﻿using dotnet6_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet6_practice.Data
{
    public class ApplicationDbContext :DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
