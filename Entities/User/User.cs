using Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User:BaseEntity
    {
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public ICollection<Post> Posts { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(300);
            builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Age).IsRequired();
        }
    }

    public enum GenderType
    {
        [Display(Name ="مرد")]
        male=0,
        [Display(Name = "زن")]
        female =1,
    }
}