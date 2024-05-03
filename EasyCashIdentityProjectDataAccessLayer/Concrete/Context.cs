using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    internal class Context: IdentityDbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; initial catalog=EasyCashDb; integrated Security=true");
        }
        //<integrated Security=true demenin amacı username ve paswrd yazmadıgımdan
        //veritabanına yansıtacagımm entitileri burda tanımlamam gerekiyor
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
    }
}
 