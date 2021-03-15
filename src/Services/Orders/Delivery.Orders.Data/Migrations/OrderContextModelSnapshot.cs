﻿// <auto-generated />
using System;
using Delivery.Orders.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Delivery.Orders.Data.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Delivery.Orders.Domain.Entitys.ShippingZipCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpireDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDateStart")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 4)
                        .HasColumnType("decimal(8,4)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ShippingZipCodes");
                });

            modelBuilder.Entity("Delivery.Orders.Domain.Entitys.ShippingZipCode", b =>
                {
                    b.OwnsOne("Delivery.Core.DomainObjects.ZipCode", "ZipCodeBegin", b1 =>
                        {
                            b1.Property<Guid>("ShippingZipCodeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasMaxLength(8)
                                .HasColumnType("varchar(8)")
                                .HasColumnName("ZipCodeBegin");

                            b1.HasKey("ShippingZipCodeId");

                            b1.ToTable("ShippingZipCodes");

                            b1.WithOwner()
                                .HasForeignKey("ShippingZipCodeId");
                        });

                    b.OwnsOne("Delivery.Core.DomainObjects.ZipCode", "ZipCodeEnd", b1 =>
                        {
                            b1.Property<Guid>("ShippingZipCodeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasMaxLength(8)
                                .HasColumnType("varchar(8)")
                                .HasColumnName("ZipCodeEnd");

                            b1.HasKey("ShippingZipCodeId");

                            b1.ToTable("ShippingZipCodes");

                            b1.WithOwner()
                                .HasForeignKey("ShippingZipCodeId");
                        });

                    b.Navigation("ZipCodeBegin");

                    b.Navigation("ZipCodeEnd");
                });
#pragma warning restore 612, 618
        }
    }
}
