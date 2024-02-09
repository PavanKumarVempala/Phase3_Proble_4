using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPIAddSubjectMarks.Models
{
    public partial class School_ProjectContext : DbContext
    {
        public School_ProjectContext()
        {
        }

        public School_ProjectContext(DbContextOptions<School_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-U064AL2;database=School_Project;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.Class1)
                    .HasName("PK__classes__71DF78ECC4C206B5");

                entity.ToTable("classes");

                entity.Property(e => e.Class1)
                    .ValueGeneratedNever()
                    .HasColumnName("class");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StuId)
                    .HasName("PK__student__E53CAB210370AD06");

                entity.ToTable("student");

                entity.Property(e => e.StuId)
                    .ValueGeneratedNever()
                    .HasColumnName("stu_id");

                entity.Property(e => e.StuClass).HasColumnName("stu_class");

                entity.Property(e => e.StuName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stu_name");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("PK__subjects__694106B0F1FB024F");

                entity.ToTable("subjects");

                entity.Property(e => e.SubId)
                    .ValueGeneratedNever()
                    .HasColumnName("sub_id");

                entity.Property(e => e.SubName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sub_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
