using Microsoft.EntityFrameworkCore;

namespace ContractManagementSystem.Data
{
    public class ApplicationDbContext : DbContext   
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) //constructor for the 'ApplicationDbContext'
        {

        }

        public DbSet<Models.Contract> Contracts { get; set; }

        
    }
}


