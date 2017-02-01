using System.Data.Entity;
using Interface;

namespace Defination
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Course> Courses { get; set; }
        
    }
}
