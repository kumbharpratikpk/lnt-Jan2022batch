﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMSApp.RESTfulApiServer.Models;

namespace PMSApp.RESTfulApiServer.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20220314062105_CreateProductsDb")]
    partial class CreateProductsDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PMSApp.RESTfulApiServer.Repository.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("productid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 100)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnName("imagepath")
                        .HasColumnType("varchar(max)");

                    b.Property<decimal?>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("price")
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0.0m);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("productname")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ReleasedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("releaseddate")
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2022, 3, 14, 11, 51, 5, 688, DateTimeKind.Local).AddTicks(5333));

                    b.Property<decimal?>("StarRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("starrating")
                        .HasColumnType("decimal(2,1)")
                        .HasDefaultValue(0.0m);

                    b.HasKey("ProductId")
                        .HasName("PK_products_productid");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
