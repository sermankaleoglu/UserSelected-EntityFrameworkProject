using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirişliEF
{
    public class CourseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("DataSource=ShopDB.db");
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-QEH642HE\SQLEXPRESS;Initial Catalog=Course;Integrated Security=SSPI;TrustServerCertificate=True;");
        }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Class> Class { get; set; }

    }
}
