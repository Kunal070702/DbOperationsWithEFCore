﻿// <auto-generated />
using System;
using DbOperationsWithEFCoreApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbOperationsWithEFCoreApp.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20250308115249_Addeddatainlanguages")]
    partial class Addeddatainlanguages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.BookPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("BookPrices");
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Indian Rupee",
                            Title = "INR"
                        },
                        new
                        {
                            Id = 2,
                            Description = "American Dollar",
                            Title = "Dollar"
                        },
                        new
                        {
                            Id = 3,
                            Description = "European Euro",
                            Title = "Euro"
                        });
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Hindi",
                            Title = "Hin"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Marathi",
                            Title = "Mara"
                        },
                        new
                        {
                            Id = 3,
                            Description = "English",
                            Title = "Eng"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tamil",
                            Title = "Tamil"
                        });
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.Book", b =>
                {
                    b.HasOne("DbOperationsWithEFCoreApp.Model.Domain.Languages", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.BookPrice", b =>
                {
                    b.HasOne("DbOperationsWithEFCoreApp.Model.Domain.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbOperationsWithEFCoreApp.Model.Domain.Currency", "Currency")
                        .WithMany("BookPrices")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.Currency", b =>
                {
                    b.Navigation("BookPrices");
                });

            modelBuilder.Entity("DbOperationsWithEFCoreApp.Model.Domain.Languages", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
