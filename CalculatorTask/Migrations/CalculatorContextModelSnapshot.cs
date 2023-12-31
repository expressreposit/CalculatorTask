﻿// <auto-generated />
using CalculatorTask;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalculatorTask.Migrations
{
    [DbContext(typeof(CalculatorContext))]
    partial class CalculatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalculatorTask.Calculation", b =>
                {
                    b.Property<int>("CalculationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalculationId"));

                    b.Property<double>("Operand1")
                        .HasColumnType("float");

                    b.Property<double>("Operand2")
                        .HasColumnType("float");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Result")
                        .HasColumnType("float");

                    b.HasKey("CalculationId");

                    b.ToTable("Calculations");
                });
#pragma warning restore 612, 618
        }
    }
}
