using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace entity_demo.Model
{
    public partial class studentContext : DbContext
    {
        public studentContext()
        {
        }

        public studentContext(DbContextOptions<studentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Ctable> Ctable { get; set; }
        public virtual DbSet<M1> M1 { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Marksb> Marksb { get; set; }
        public virtual DbSet<State1> State1 { get; set; }
        public virtual DbSet<Stud> Stud { get; set; }
        public virtual DbSet<StudentDetails1> StudentDetails1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=localhost;Uid=root;Pwd=Ritzzxi1.;Database=student;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("city");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasColumnName("cname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stid)
                    .HasColumnName("stid")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Cuid)
                    .HasName("PRIMARY");

                entity.ToTable("course");

                entity.Property(e => e.Cuid)
                    .HasColumnName("cuid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cuname)
                    .IsRequired()
                    .HasColumnName("cuname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ctable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ctable");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sub1)
                    .HasColumnName("sub1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sub2)
                    .HasColumnName("sub2")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<M1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("m1");

                entity.Property(e => e.M11).HasColumnName("m1");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("sid")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marks>(entity =>
            {
                entity.HasKey(e => new { e.Sid, e.Testno })
                    .HasName("PRIMARY");

                entity.ToTable("marks");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Testno).HasColumnName("testno");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.M2).HasColumnName("m2");
            });

            modelBuilder.Entity<Marksb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("marksb");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.M2).HasColumnName("m2");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("sid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("status_date")
                    .HasColumnType("date");

                entity.Property(e => e.Testno).HasColumnName("testno");
            });

            modelBuilder.Entity<State1>(entity =>
            {
                entity.HasKey(e => e.Stid)
                    .HasName("PRIMARY");

                entity.ToTable("state1");

                entity.Property(e => e.Stid)
                    .HasColumnName("stid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("stud");

                entity.HasIndex(e => e.Fname)
                    .HasName("i1");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentDetails1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("student_details1");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("sid")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
