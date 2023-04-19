﻿// <auto-generated />
using System;
using EStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EStore.Migrations
{
    [DbContext(typeof(DBConnect))]
    [Migration("20230419130105_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EStore.Model.account", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("account");
                });

            modelBuilder.Entity("EStore.Model.category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("EStore.Model.customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("EStore.Model.order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("id_customer")
                        .HasColumnType("int");

                    b.Property<int>("id_staff")
                        .HasColumnType("int");

                    b.Property<DateTime>("order_date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("id_customer");

                    b.HasIndex("id_staff");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("EStore.Model.orderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("id_order")
                        .HasColumnType("int");

                    b.Property<int>("id_product")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<float>("total_price")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("id_order");

                    b.HasIndex("id_product");

                    b.ToTable("order_detail");
                });

            modelBuilder.Entity("EStore.Model.product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_category")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("thumnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("id_category");

                    b.ToTable("product");
                });

            modelBuilder.Entity("EStore.Model.staff", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("EStore.Model.order", b =>
                {
                    b.HasOne("EStore.Model.customer", null)
                        .WithMany()
                        .HasForeignKey("id_customer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EStore.Model.staff", null)
                        .WithMany()
                        .HasForeignKey("id_staff")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EStore.Model.orderDetail", b =>
                {
                    b.HasOne("EStore.Model.order", null)
                        .WithMany()
                        .HasForeignKey("id_order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EStore.Model.product", null)
                        .WithMany()
                        .HasForeignKey("id_product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EStore.Model.product", b =>
                {
                    b.HasOne("EStore.Model.category", null)
                        .WithMany()
                        .HasForeignKey("id_category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
