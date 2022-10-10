using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public partial class InterviewContext:DbContext
    {
        public InterviewContext()
        {

        }

        public InterviewContext(DbContextOptions<InterviewContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.ToTable("User");

                entity.Property(e => e.Name)
                    .HasColumnName("UserName")
                    .HasMaxLength(15);

                entity.Property(e => e.Surname)
                    .HasColumnName("UserSurname")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("UserEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("UserPassword")
                    .HasMaxLength(50);





            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
