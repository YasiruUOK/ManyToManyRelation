using ManyToManyRelation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Data
{
    public class ManytoManyContext: DbContext
    {
        public ManytoManyContext(DbContextOptions<ManytoManyContext> options): base (options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(pt => new { pt.PostId, pt.TagId });
            modelBuilder.Entity<PostTag>().
                HasOne(pt => pt.Post).WithMany(pt => pt.PostTags).HasForeignKey(p => p.PostId);
            modelBuilder.Entity<PostTag>().
                HasOne(pt => pt.Tag).WithMany(pt => pt.PostTags).HasForeignKey(p => p.TagId);
        }
    }
}
