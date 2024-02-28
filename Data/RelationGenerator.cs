using Core.Models;
using idflNet.Core.Models.BaseModel;
using Microsoft.EntityFrameworkCore;

namespace idflNet.Data
{
    public class RelationGenerator
    {
        public static void Run(ModelBuilder modelBuilder)
        {
            GenerateLanguageRelation(modelBuilder);
            GenerateUserRelation(modelBuilder);
            GenerateUserClientRelation(modelBuilder);
            GeneratePageMetaRelation(modelBuilder);
            GenerateBannerHomePageRelation(modelBuilder);
        }
        private static void GenerateLanguageRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageModel>(entity =>
            {
                entity.ToTable("dblanguage");
                entity.HasMany(m => m.PageMetaDataModels)
                .WithOne(o => o.LanguageModel)
                .HasConstraintName("fk_language_pagemetadata")
                .HasForeignKey(k => k.LanguageId);
            });
        }
        private static void GenerateUserRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.ToTable("dbuser");
                entity.HasMany(m => m.UserClientInformationModels)
                .WithOne(o => o.UserModel)
                .HasForeignKey(f => f.UserId)
                .HasConstraintName("fk_user_userInfo");
            });
        }
        private static void GenerateUserClientRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserClientInformationModel>(entity =>
            {
                entity.ToTable("dbuserclient");
            });
        }
        private static void GeneratePageMetaRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PageMetaDataModel>(entity =>
            {
                entity.ToTable("dbpagemetadata");
            });
        }

        private static void GenerateBannerHomePageRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BannerHomePageModel>(entity =>
            {
                entity.ToTable("dbbannerhomepage");
            });
        }
    }
}