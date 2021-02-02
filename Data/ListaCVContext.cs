﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Website___Ricardo.Data
{
    public class ApplicationDbContext : ApplicationIdentity
    {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base (options)
    {
    }
}