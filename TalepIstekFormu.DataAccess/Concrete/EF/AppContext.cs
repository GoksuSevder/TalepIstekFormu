using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.DataAccess.Concrete.EF
{
   public class AppContext :DbContext
    {
        public AppContext() : base("name=AppContext")
        {

        }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employ> Employs { get; set; }
    }
}
