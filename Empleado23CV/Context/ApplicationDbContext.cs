using Empleado23CV.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Empleado23CV.Context
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Se coloca la cadena de conexion
            optionsBuilder.UseMySQL("Server=localhost; database=23CV; user=root; password=;sql");

            

    
        }
        public DbSet<Empleados> Empleado { get; set; }

    }
}
