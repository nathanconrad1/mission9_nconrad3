﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission9_nconrad3.Models;

namespace mission9_nconrad3.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    partial class BookstoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission9_nconrad3.Models.BasketLineItem", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineId");

                    b.HasIndex("BookId");

                    b.HasIndex("BuyId");

                    b.ToTable("BasketLineItem");
                });

            modelBuilder.Entity("mission9_nconrad3.Models.Book", b =>
                {
                    b.Property<long>("BookId")
                        .HasColumnName("BookID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnName("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<long>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("mission9_nconrad3.Models.Buy", b =>
                {
                    b.Property<int>("BuyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("BuyId");

                    b.ToTable("Buys");
                });

            modelBuilder.Entity("mission9_nconrad3.Models.BasketLineItem", b =>
                {
                    b.HasOne("mission9_nconrad3.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("mission9_nconrad3.Models.Buy", null)
                        .WithMany("Lines")
                        .HasForeignKey("BuyId");
                });
#pragma warning restore 612, 618
        }
    }
}