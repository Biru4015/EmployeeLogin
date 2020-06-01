﻿// <auto-generated />
using GreetingAppRepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GreetingAppRepositoryLayer.Migrations
{
    [DbContext(typeof(UserDatabaseContext))]
    [Migration("20200601074037_mofgratig")]
    partial class mofgratig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GreetingAppCommonLayer.GreetingModel", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<int>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("EmpID");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
