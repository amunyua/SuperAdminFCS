using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SuperAdminFCS.Models
{
    public class FCSDataContext : DbContext 
    {
        public DbSet<Menu> Menus { set; get;}
    }
}