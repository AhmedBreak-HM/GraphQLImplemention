using GraphQLImplemention.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLImplemention.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new[]
            {
                new Student{ Id= 1, Name="ahmed", Roll="1001"},
                new Student{ Id= 2, Name="mohamed", Roll="1002"},
                new Student{ Id= 3, Name="amer", Roll="1003"},
                new Student{ Id= 4, Name="hazeem", Roll="1004"},
                new Student{ Id= 5, Name="hamza", Roll="1005"},
                new Student{ Id= 6, Name="hassan", Roll="1006"},
                new Student{ Id= 7, Name="ebrahim", Roll="1007"},
                new Student{ Id= 8, Name="moataz", Roll="1008"},
            });
        }
    }
}
