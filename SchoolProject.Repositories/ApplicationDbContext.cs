﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;

namespace SchoolProject.Repositories
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base() { }

        public DbSet<ApplicationUser> ApplicationUsers {  get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Session> YearlySessions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure your database connection here
                optionsBuilder.UseSqlServer("SchoolProjectWebContextConnection");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUserLogin<string>>()
        .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            builder.Entity<AssignGrade>().HasOne(x => x.Grade)
          .WithMany(z => z.AssignGrades).HasForeignKey(x => x.GradeId).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<AssignGrade>().HasOne(x => x.Teacher).
                WithMany(z => z.AssignGrades).HasForeignKey(x => x.TeacherId).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Enroll>().HasOne(x => x.Student).
                WithMany(z => z.YearlySession).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x => x.Session).
                WithMany(z => z.Enrollment).HasForeignKey(x => x.SessionId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x => x.Grade).
                WithMany(z => z.Enrolls).HasForeignKey(x => x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TeacherSession>().HasOne(x => x.Teacher).
                WithMany(z => z.TeacherSessions).HasForeignKey(x => x.TeacherId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TeacherSession>().HasOne(x => x.Session).
                WithMany(z => z.TeacherSessions).HasForeignKey(x => x.SessionId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
