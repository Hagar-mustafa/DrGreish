﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleMiniProject.Data;

namespace SampleMiniProject.Migrations
{
    [DbContext(typeof(CompanyDB))]
    [Migration("20220428070049_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleMiniProject.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SampleMiniProject.Models.ReceivedSample", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfSamples")
                        .HasColumnType("int");

                    b.Property<string>("ReceivingSide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SampleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SampleStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientId");

                    b.ToTable("ReceivedSamples");
                });

            modelBuilder.Entity("SampleMiniProject.Models.ReceivedSample", b =>
                {
                    b.HasOne("SampleMiniProject.Models.Client", "Client")
                        .WithMany("ReceivedSamples")
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SampleMiniProject.Models.Client", b =>
                {
                    b.Navigation("ReceivedSamples");
                });
#pragma warning restore 612, 618
        }
    }
}
