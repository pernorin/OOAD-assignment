﻿// <auto-generated />
using System;
using BlogAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogAPI.Models.Entities.ArticleAuthorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArticleAuthors");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ArticleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArticleAuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("ArticleTagId")
                        .HasColumnType("int");

                    b.Property<string>("ArticleText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArticleAuthorId");

                    b.HasIndex("ArticleTagId");

                    b.HasIndex("ContentTypeId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ArticleTagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.ToTable("ArticleTags");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ContentTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ContentType")
                        .IsUnique();

                    b.ToTable("ContentTypes");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ArticleEntity", b =>
                {
                    b.HasOne("BlogAPI.Models.Entities.ArticleAuthorEntity", "ArticleAuthor")
                        .WithMany("AuthorArticles")
                        .HasForeignKey("ArticleAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogAPI.Models.Entities.ArticleTagEntity", "ArticleTag")
                        .WithMany("TagArticles")
                        .HasForeignKey("ArticleTagId");

                    b.HasOne("BlogAPI.Models.Entities.ContentTypeEntity", "ContentType")
                        .WithMany("Articles")
                        .HasForeignKey("ContentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticleAuthor");

                    b.Navigation("ArticleTag");

                    b.Navigation("ContentType");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ArticleAuthorEntity", b =>
                {
                    b.Navigation("AuthorArticles");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ArticleTagEntity", b =>
                {
                    b.Navigation("TagArticles");
                });

            modelBuilder.Entity("BlogAPI.Models.Entities.ContentTypeEntity", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
