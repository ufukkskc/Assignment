using System.Data.Entity;

namespace EFCodeFirstStudentApp
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDBConnectionString")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
