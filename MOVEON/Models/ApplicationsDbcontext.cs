using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MOVEON.Models
{
    public class ApplicationsDbcontext:DbContext
    {
        public ApplicationsDbcontext() : base("Data Source=CHETUIWK802\\SQLEXPRESS;" +
            "Initial Catalog=EmpList;Integrated Security=True;Pooling=False") { }
        public DbSet<Employess> employesses { get; set; }
    }
}