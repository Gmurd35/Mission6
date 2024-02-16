using Microsoft.EntityFrameworkCore;

namespace Mission6_Murdock.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base (options) 
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
