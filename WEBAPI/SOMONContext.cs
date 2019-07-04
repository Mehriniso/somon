using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEBAPI
{
    public class SOMONContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SOMONContext() : base("name=SOMONContext")
        {
        }

        public System.Data.Entity.DbSet<SOMON.DAL.Tasks> Tasks { get; set; }
        public System.Data.Entity.DbSet<SOMON.DAL.Category> Categories { get; set; }
    }
}
