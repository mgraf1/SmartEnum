﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartEnum.EFCore.IntegrationTests.DbContext;

#nullable disable

namespace SmartEnum.EFCore.IntegrationTests.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20220809023120_AddOwnedEntity")]
    partial class AddOwnedEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("SmartEnum.EFCore.IntegrationTests.DbContext.Entities.SomeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Weekday")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SomeEntities");
                });

            modelBuilder.Entity("SmartEnum.EFCore.IntegrationTests.DbContext.Entities.SomeEntity", b =>
                {
                    b.OwnsOne("SmartEnum.EFCore.IntegrationTests.DbContext.Entities.SomeOwnedEntity", "OwnedEntity", b1 =>
                        {
                            b1.Property<int>("SomeEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Value")
                                .HasColumnType("INTEGER")
                                .HasColumnName("Owned1Value");

                            b1.Property<int?>("Weekday")
                                .HasColumnType("INTEGER")
                                .HasColumnName("Owned1Weekday");

                            b1.HasKey("SomeEntityId");

                            b1.ToTable("SomeEntities");

                            b1.WithOwner()
                                .HasForeignKey("SomeEntityId");
                        });

                    b.Navigation("OwnedEntity");
                });
#pragma warning restore 612, 618
        }
    }
}