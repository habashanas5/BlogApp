﻿using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
    }
}
