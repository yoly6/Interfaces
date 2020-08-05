using System;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
