﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tokhaiyteProject.Models;

namespace tokhaiyteProject.Migrations
{
    [DbContext(typeof(tokhaiyteDbContext))]
    [Migration("20200911072154_tokhaiModeltable")]
    partial class tokhaiModeltable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tokhaiyteProject.Models.Entities.tokhaimodel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BirthYear")
                        .HasColumnType("int");

                    b.Property<bool>("Dauhong")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GateId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ho")
                        .HasColumnType("bit");

                    b.Property<int>("HoChieu")
                        .HasColumnType("int");

                    b.Property<int>("IdTihhe")
                        .HasColumnType("int");

                    b.Property<int>("IdTinhs")
                        .HasColumnType("int");

                    b.Property<bool>("Khotho")
                        .HasColumnType("bit");

                    b.Property<bool>("NoiBan")
                        .HasColumnType("bit");

                    b.Property<bool>("Non")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoGhet")
                        .HasColumnType("int");

                    b.Property<string>("Sohieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sot")
                        .HasColumnType("bit");

                    b.Property<bool>("Tieuchay")
                        .HasColumnType("bit");

                    b.Property<string>("VietNam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VietNam_e")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VietNam_s")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("denquocgia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("dongvat")
                        .HasColumnType("bit");

                    b.Property<int>("entryDay")
                        .HasColumnType("int");

                    b.Property<int>("entryMonth")
                        .HasColumnType("int");

                    b.Property<int>("entryYear")
                        .HasColumnType("int");

                    b.Property<int>("idDistrict")
                        .HasColumnType("int");

                    b.Property<int>("idProvince")
                        .HasColumnType("int");

                    b.Property<int>("idWard")
                        .HasColumnType("int");

                    b.Property<bool>("oTo")
                        .HasColumnType("bit");

                    b.Property<string>("other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("startDay")
                        .HasColumnType("int");

                    b.Property<int>("startMonth")
                        .HasColumnType("int");

                    b.Property<int>("startYear")
                        .HasColumnType("int");

                    b.Property<bool>("tauBay")
                        .HasColumnType("bit");

                    b.Property<bool>("tauThuyen")
                        .HasColumnType("bit");

                    b.Property<bool>("tiepxuc")
                        .HasColumnType("bit");

                    b.Property<string>("vacxin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("xuatHuyet")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("tokhaimodels");
                });
#pragma warning restore 612, 618
        }
    }
}
