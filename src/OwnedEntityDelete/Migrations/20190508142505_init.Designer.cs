﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OwnedEntityDelete;

namespace OwnedEntityDelete.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20190508142505_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OwnedEntityDelete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OwnedEntityDelete.Order", b =>
                {
                    b.OwnsOne("OwnedEntityDelete.StreetAddress", "ShippingAddress", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasMaxLength(100);

                            b1.Property<string>("Street")
                                .HasMaxLength(100);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.HasOne("OwnedEntityDelete.Order")
                                .WithOne("ShippingAddress")
                                .HasForeignKey("OwnedEntityDelete.StreetAddress", "OrderId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
