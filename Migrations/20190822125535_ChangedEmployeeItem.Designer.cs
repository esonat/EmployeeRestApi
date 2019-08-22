﻿// <auto-generated />
using EmployeeRestApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeRestApi.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20190822125535_ChangedEmployeeItem")]
    partial class ChangedEmployeeItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeRestApi.Models.EmployeeItem", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dateofbirth");

                    b.Property<string>("department");

                    b.Property<string>("firstname");

                    b.Property<string>("lastname");

                    b.HasKey("id");

                    b.ToTable("EmployeeItems");
                });
#pragma warning restore 612, 618
        }
    }
}