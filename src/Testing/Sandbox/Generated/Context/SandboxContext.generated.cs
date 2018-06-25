//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sandbox
{
   public partial class SandboxContext : Microsoft.EntityFrameworkCore.DbContext
   {
      public Microsoft.EntityFrameworkCore.DbSet<Sandbox.Blog> Blogs { get; set; }
      public Microsoft.EntityFrameworkCore.DbSet<Sandbox.Post> Posts { get; set; }

      private static string ConnectionString { get; set; } = @"Data Source=.\sqlexpress;Initial Catalog=Sandbox;Integrated Security=True";

      public SandboxContext() : base()
      {
      }

      public SandboxContext(DbContextOptions<SandboxContext> options) : base(options)
      {
      }

      partial void CustomInit(ref DbContextOptionsBuilder optionsBuilder);

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseLazyLoadingProxies();

         CustomInit(ref optionsBuilder);
      }

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<Sandbox.Blog>()
                     .ToTable("Blogs")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<Sandbox.Blog>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .ValueGeneratedOnAdd();
         modelBuilder.Entity<Sandbox.Blog>()
                     .Property(t => t.Url)
                     .HasMaxLength(256);

         modelBuilder.Entity<Sandbox.Post>()
                     .ToTable("Posts")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<Sandbox.Post>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .ValueGeneratedOnAdd();
         modelBuilder.Entity<Sandbox.Post>()
                     .Property(t => t.Title)
                     .HasMaxLength(200)
                     .IsRequired();
         modelBuilder.Entity<Sandbox.Post>()
                     .HasOne(x => x.Blog)
                     .WithMany(x => x.Posts);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}