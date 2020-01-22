﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infrastructure.Data.Context
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CoreProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new DataContext(builder.Options);
        }
    }
}
