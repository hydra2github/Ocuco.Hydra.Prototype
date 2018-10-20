﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ocuco.DataModel.Hydradb.Context;

namespace Ocuco.DataModel.Hydradb.Migrations
{
    [DbContext(typeof(HydraContext))]
    [Migration("20180919154641_InitHydrasqldb")]
    partial class InitHydrasqldb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ocuco.DataModel.Hydradb.Entities.ArtOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderNumber");

                    b.HasKey("Id");

                    b.ToTable("ArtOrders");
                });

            modelBuilder.Entity("Ocuco.DataModel.Hydradb.Entities.ArtOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ArtOrderItem");
                });

            modelBuilder.Entity("Ocuco.DataModel.Hydradb.Entities.ArtProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtDating");

                    b.Property<string>("ArtDescription");

                    b.Property<string>("ArtId");

                    b.Property<string>("Artist");

                    b.Property<DateTime>("ArtistBirthDate");

                    b.Property<DateTime>("ArtistDeathDate");

                    b.Property<string>("ArtistNationality");

                    b.Property<string>("Category");

                    b.Property<decimal>("Price");

                    b.Property<string>("Size");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ArtProducts");
                });

            modelBuilder.Entity("Ocuco.DataModel.Hydradb.Entities.ArtOrderItem", b =>
                {
                    b.HasOne("Ocuco.DataModel.Hydradb.Entities.ArtOrder", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("Ocuco.DataModel.Hydradb.Entities.ArtProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}