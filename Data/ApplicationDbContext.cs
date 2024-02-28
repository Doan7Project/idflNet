using Core.Models;
using idflNet.Core.Models.BaseModel;
using Microsoft.EntityFrameworkCore;

namespace idflNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LanguageModel> Language { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<UserClientInformationModel> UserClientInformation { get; set; }
        public DbSet<PageMetaDataModel> PageMetaData { get; set; }
        public DbSet<BannerHomePageModel> BannerHomePage { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
        .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            RelationGenerator.Run(modelBuilder);
            DataGenerator.Run(modelBuilder);
        }
    }
}