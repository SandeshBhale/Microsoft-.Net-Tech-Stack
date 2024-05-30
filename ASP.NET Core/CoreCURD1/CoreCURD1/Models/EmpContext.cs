using Microsoft.EntityFrameworkCore;


namespace CoreCURD1.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> ec) : base(ec)
        {

        }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
    }
}
