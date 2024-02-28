﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using idflNet.Data;

#nullable disable

namespace idflNet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240228095520_add_bannerpagemodel_to_db")]
    partial class add_bannerpagemodel_to_db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Models.BannerHomePageModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("dbbannerhomepage", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("89bce33a-279a-4a36-b3ab-74e9b083facb"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(8228),
                            Url = "/images/default/banner_1.jpg"
                        },
                        new
                        {
                            Id = new Guid("4127f7c0-59fc-47e6-ab19-9f2a23a02028"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(8282),
                            Url = "/images/default/banner_2.jpg"
                        },
                        new
                        {
                            Id = new Guid("c2949f3d-d948-408e-910d-dcc50614e0a3"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(8318),
                            Url = "/images/default/banner_3.jpg"
                        });
                });

            modelBuilder.Entity("Core.Models.PageMetaDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Field")
                        .HasColumnType("longtext");

                    b.Property<string>("Key")
                        .HasColumnType("longtext");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Session")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("dbpagemetadata", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9efa048d-512a-4ad1-befd-80b548571eee"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7828),
                            Field = "header",
                            Key = "home",
                            LanguageId = new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"),
                            Session = "sessionService",
                            Value = "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG"
                        },
                        new
                        {
                            Id = new Guid("4e2fdcd1-f2d4-45f3-8931-e024ba5f4c7a"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7831),
                            Field = "header",
                            Key = "home",
                            LanguageId = new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"),
                            Session = "sessionService",
                            Value = "WE GUARANTEE QUALITY"
                        },
                        new
                        {
                            Id = new Guid("5f19bfc7-3b73-4578-9707-742f26014722"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7833),
                            Field = "subHeader",
                            Key = "home",
                            LanguageId = new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"),
                            Session = "sessionService",
                            Value = "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp."
                        },
                        new
                        {
                            Id = new Guid("b3bf0338-e5e1-4193-bdeb-7a1dcafd9f9b"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7835),
                            Field = "subHeader",
                            Key = "home",
                            LanguageId = new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"),
                            Session = "sessionService",
                            Value = "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL."
                        });
                });

            modelBuilder.Entity("Core.Models.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("dbuser", (string)null);
                });

            modelBuilder.Entity("idflNet.Core.Models.BaseModel.LanguageModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("dblanguage", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"),
                            Code = "vi",
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7787),
                            IsActive = true,
                            Name = "Tiếng việt"
                        },
                        new
                        {
                            Id = new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"),
                            Code = "en",
                            CreatedAt = new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7802),
                            IsActive = true,
                            Name = "English"
                        });
                });

            modelBuilder.Entity("idflNet.Core.Models.BaseModel.UserClientInformationModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<string>("Dob")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Ward")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("dbuserclient", (string)null);
                });

            modelBuilder.Entity("Core.Models.PageMetaDataModel", b =>
                {
                    b.HasOne("idflNet.Core.Models.BaseModel.LanguageModel", "LanguageModel")
                        .WithMany("PageMetaDataModels")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_language_pagemetadata");

                    b.Navigation("LanguageModel");
                });

            modelBuilder.Entity("idflNet.Core.Models.BaseModel.UserClientInformationModel", b =>
                {
                    b.HasOne("Core.Models.UserModel", "UserModel")
                        .WithMany("UserClientInformationModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_userInfo");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Core.Models.UserModel", b =>
                {
                    b.Navigation("UserClientInformationModels");
                });

            modelBuilder.Entity("idflNet.Core.Models.BaseModel.LanguageModel", b =>
                {
                    b.Navigation("PageMetaDataModels");
                });
#pragma warning restore 612, 618
        }
    }
}
