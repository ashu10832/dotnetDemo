﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using code_first.model;

namespace code_first.Migrations
{
    [DbContext(typeof(ConnectContext))]
    partial class ConnectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("code_first.model.StoreDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("lastPurchased")
                        .HasColumnType("datetime");

                    b.Property<string>("productName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("StoreDTO");
                });
#pragma warning restore 612, 618
        }
    }
}
