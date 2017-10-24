namespace MentorViet.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MentorVietContext : DbContext
    {
        public MentorVietContext()
            : base("name=MentorVietContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
