﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProvaEdesoft.Models;
using System;

namespace ProvaEdesoft.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProvaEdesoft.Models.Cao", b =>
                {
                    b.Property<int>("IdCao")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<string>("Raca")
                        .HasMaxLength(100);

                    b.HasKey("IdCao");

                    b.ToTable("tblCao");
                });

            modelBuilder.Entity("ProvaEdesoft.Models.Dono", b =>
                {
                    b.Property<int>("IdDono")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("IdDono");

                    b.ToTable("tblDono");
                });

            modelBuilder.Entity("ProvaEdesoft.Models.Relacao_Dono_Cao", b =>
                {
                    b.Property<int>("IdCao");

                    b.Property<int>("IdDono");

                    b.HasKey("IdCao", "IdDono");

                    b.ToTable("tblDono_Cao");
                });
#pragma warning restore 612, 618
        }
    }
}