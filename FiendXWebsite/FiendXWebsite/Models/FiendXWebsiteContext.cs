﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FiendXWebsite.Models
{
    public class FiendXWebsiteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FiendXWebsiteContext() : base("name=FiendXWebsiteContext")
        {
        }

        public System.Data.Entity.DbSet<FiendXWebsite.Models.Gig> Gigs { get; set; }

        public System.Data.Entity.DbSet<FiendXWebsite.Models.Genre> Genres { get; set; }
    }
}
