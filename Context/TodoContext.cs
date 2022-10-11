using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public partial class TodoContext : DbContext
    {
        public TodoContext()
        {

        }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>(entity =>{
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.ToTable("Todo");

                entity.Property(e => e.TodoName)
                    .HasColumnName("TodoName")
                    .HasMaxLength(255);

                entity.Property(e => e.TodoType)
                    .HasColumnName("TodoType")
                    .HasMaxLength(120);

                entity.Property(e => e.TodoDescription)
                    .HasColumnName("TodoDescription")
                    .HasMaxLength(255);

            });
            OnModelCreating(modelBuilder);

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
