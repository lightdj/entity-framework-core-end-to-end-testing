﻿using Microsoft.EntityFrameworkCore;

namespace Persistence.Database.Factories
{
    internal interface IDbContextFactory<out TDbContext> 
        where TDbContext : DbContext
    {
        TDbContext CreateDbContext(string connectionString);
    }
}