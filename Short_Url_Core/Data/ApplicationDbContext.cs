using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    #region "Seed Data"

        //    builder.Entity<ShortUrlSetting>().HasData(
        //        new { Id = 1, UserName = "Guest", Prefix = "G" , Postfix  = "", CreatedOn = DateTime.Now, CreatedBy =1}                
        //    );
        //    #endregion
        //}

        public virtual DbSet<LongUrl> LongUrls { get; set; }
        public virtual DbSet<ShortUrlSetting> ShortUrlSettings { get; set; }
        public virtual DbSet<UrlLog> UrlLogs { get; set; }
    }
}
