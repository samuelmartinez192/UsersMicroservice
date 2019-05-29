using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersMicroservice.Models;

namespace UsersMicroservice.DBContexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    IdUser = 1,
                    NumMatricula = 182948,
                    Nombres = "Samuel Martin",
                    Apellidos = "Martinez Magdaleno",
                    Sexo = 'M',
                    Ingreso = "SMARTINEZ",
                    FechaIngreso = DateTime.Now,
                    Estatus = true
                },
                  new User
                  {
                      IdUser = 2,
                      NumMatricula = 112897,
                      Nombres = "Cesar Javier",
                      Apellidos = "Maldonado Florez",
                      Sexo = 'M',
                      Ingreso = "SMARTINEZ",
                      FechaIngreso = DateTime.Now,
                      Estatus = true
                  },
                    new User
                    {
                        IdUser = 3,
                        NumMatricula = 182996,
                        Nombres = "Adrian",
                        Apellidos = "Hernandez Rivas",
                        Sexo = 'M',
                        Ingreso = "SMARTINEZ",
                        FechaIngreso = DateTime.Now,
                        Estatus = true
                    }
                );
        }
    }
}
